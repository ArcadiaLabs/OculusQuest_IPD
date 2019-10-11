using UnityEngine;
using System.Collections;
using TMPro;

public class TMP_test : MonoBehaviour
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

    void Update()
    {
        m_text = GetComponent<TextMeshProUGUI>();
        m_text.SetText("The first number is {0} and the 2nd is {1:2} and the 3rd is {3:0}.", 4, 6.345f, 3.5f);
        // The text displayed will be:
        // The first number is 4 and the 2nd is 6.35 and the 3rd is 4.
    }
}