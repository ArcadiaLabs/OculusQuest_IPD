using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ReadIPD_TMP : MonoBehaviour
{
    public enum objectType { TextMeshPro = 0, TextMeshProUGUI = 1 };

    public objectType ObjectType;

    private TMP_Text m_text;

    [Tooltip("The delay between IPD readings (in seconds).")]
    public float updateInterval = 0.5f;

    private float ipdValue = 0.1f;
    private float oldValue;

    protected float updateTime;

    void Awake()
    {
        // Get a reference to the TMP text component if one already exists otherwise add one.
        // This example show the convenience of having both TMP components derive from TMP_Text. 
        if (ObjectType == 0)
            m_text = GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        else
            m_text = GetComponent<TextMeshProUGUI>() ?? gameObject.AddComponent<TextMeshProUGUI>();
    }

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
        //TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        m_text.SetText(" IPD : {0:2} mm ", value);
        //m_text.SetText("<mark=#000000aa> IPD : {0:2} mm </mark>", value);
    }
}
