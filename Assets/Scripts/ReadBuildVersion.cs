using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ReadBuildVersion : MonoBehaviour
{
    public enum objectType { TextMeshPro = 0, TextMeshProUGUI = 1 };

    public objectType ObjectType;

    private TMP_Text m_text;

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

        UpdateText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateText()
    {
        //Update the text shown in the text component by setting the `text` variable
        //TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
        m_text.SetText("Version " + Application.version);
        //m_text.SetText("<mark=#000000aa> IPD : {0:2} mm </mark>", value);
    }
}
