using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderHandle : MonoBehaviour
{
    public static float mouseSensitivity;
    [SerializeField] Slider mouseSensitivitySlider;
    [SerializeField] TMP_Text mouseSensitivitySliderValue;

    public void Start()
    {
        if (PlayerPrefs.HasKey("sensitivity"))
        {
            mouseSensitivitySlider.value = PlayerPrefs.GetFloat("sensitivity");
        }
        else
        {
            mouseSensitivitySlider.value = 6;
        }

        mouseSensitivitySlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        setMouseSensitivity(mouseSensitivitySlider.value);
        setMouseSensetivitySliderText();
    }

    void setMouseSensitivity(float value)
    {
        PlayerPrefs.SetFloat("sensitivity", value);
    }

    public float getMouseSensetivity()//set value else default to 6
    {

        if (PlayerPrefs.HasKey("sensitivity"))
        {
            return mouseSensitivity;
        }

        else
        {
            PlayerPrefs.SetFloat("sensitivity", 1);
            return 1;
        }

    }

    void setMouseSensetivitySliderText()
    {
        mouseSensitivitySliderValue.text = "" + mouseSensitivitySlider.value;
    }
}