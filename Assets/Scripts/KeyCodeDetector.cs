using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyCodeDetector : MonoBehaviour
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

    }

    // Update is called once per frame
    void Update()
    {
        // Buttons pressed
        if (OVRInput.Get(OVRInput.Button.One))
        {
            m_text.SetText("Button A pressed");
        }
        else if (OVRInput.Get(OVRInput.Button.Two))
        {
            m_text.SetText("Button B pressed");
        }
        else if (OVRInput.Get(OVRInput.Button.Three))
        {
            m_text.SetText("Button X pressed");
        }
        else if (OVRInput.Get(OVRInput.Button.Four))
        {
            m_text.SetText("Button Y pressed");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            m_text.SetText("Primary Thumbstick pressed");
        }
        else if (OVRInput.Get(OVRInput.Button.SecondaryThumbstick))
        {
            m_text.SetText("Secondary Thumbstick pressed");
        }

        // Buttons touched
        else if (OVRInput.Get(OVRInput.Touch.One))
        {
            m_text.SetText("Button A touched");
        }
        else if (OVRInput.Get(OVRInput.Touch.Two))
        {
            m_text.SetText("Button B touched");
        }
        else if (OVRInput.Get(OVRInput.Touch.Three))
        {
            m_text.SetText("Button X touched");
        }
        else if (OVRInput.Get(OVRInput.Touch.Four))
        {
            m_text.SetText("Button Y touched");
        }
        else if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            m_text.SetText("Primary Thumbstick touched");
        }
        else if (OVRInput.Get(OVRInput.Touch.SecondaryThumbstick))
        {
            m_text.SetText("Secondary Thumbstick touched");
        }

        // Primary Thumbstick (D-pad mode)
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight))
        {
            m_text.SetText("Primary Thumbstick : Right");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft))
        {
            m_text.SetText("Primary Thumbstick : Left");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
        {
            m_text.SetText("Primary Thumbstick : Up");
        }
        else if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown))
        {
            m_text.SetText("Primary Thumbstick : Down");
        }

        // Secondary Thumbstick (D-pad mode)
        else if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            m_text.SetText("Secondary Thumbstick : Right");
        }
        else if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            m_text.SetText("Secondary Thumbstick : Left");
        }
        else if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
        {
            m_text.SetText("Secondary Thumbstick : Up");
        }
        else if (OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
        {
            m_text.SetText("Secondary Thumbstick : Down");
        }

        else foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                m_text.SetText("KeyCode: " + kcode);
            }
        }
    }
}
