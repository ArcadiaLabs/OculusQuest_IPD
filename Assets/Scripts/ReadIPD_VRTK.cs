using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ReadIPD_VRTK : MonoBehaviour
{
    [Tooltip("Toggles whether the IPD text is visible.")]
    public bool displayIPD = true;
    [Tooltip("The size of the font the IPD is displayed in.")]
    public int fontSize = 32;
    [Tooltip("The position of the IPD text within the headset view.")]
    public Vector3 position = Vector3.zero;
    [Tooltip("The colour of the IPD text.")]
    public Color textColor = Color.green;
    [Tooltip("The delay between IPD readings (in seconds).")]
    public float updateInterval = 0.5f;
    [Tooltip("The text component on which applying the script.")]
    public Text textComponent;


    private float ipdValue = 0.1f;
    private float oldValue;

    protected float updateTime;

    // Start is called before the first frame update
    void Start()
    {
        ipdValue = OVRPlugin.ipd * 1000;
        ipdValue = (float)Math.Round((double)ipdValue, 2);
        oldValue = ipdValue;

        UpdateText(ipdValue);

    }

    // Update is called once per frame
    void Update()
    {
        updateTime += Time.unscaledDeltaTime;
        if (updateTime > updateInterval)
        {
            ipdValue = OVRPlugin.ipd * 1000;
            ipdValue = (float)Math.Round((double)ipdValue, 2);
            if (ipdValue != oldValue)
            {
                oldValue = ipdValue;
                UpdateText(ipdValue);
            }
            updateTime = 0;
        }


    }

    void UpdateText(float value)
    {
        //Update the text shown in the text component by setting the `text` variable
        textComponent.fontSize = fontSize;
        textComponent.transform.localPosition = position;
        textComponent.color = textColor;
        textComponent.text = "IPD : " + value + "mm";
    }
}
