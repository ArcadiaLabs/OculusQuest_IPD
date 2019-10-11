using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ReadIPD1 : MonoBehaviour
{
    public Text textComponent;

    [Tooltip("The delay between IPD readings (in seconds).")]
    public float updateInterval = 0.5f;

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
            // ipdValue += 0.1f;
            // UpdateText(ipdValue);
    }

    void UpdateText(float value)
    {
        //Update the text shown in the text component by setting the `text` variable
        textComponent.text = "IPD : " + value + "mm";
    }
}
