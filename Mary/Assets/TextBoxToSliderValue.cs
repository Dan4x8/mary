using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxToSliderValue : MonoBehaviour
{
    [SerializeField]
    private Slider _slider;

    private TMPro.TMP_InputField _field;

    private void Awake()
    {
        _field = GetComponent<TMPro.TMP_InputField>();
        _field.text = _slider.value.ToString();
    }

    public void UpdateText(float value)
    {
        _field.text = value.ToString();
    }

    public void SetSliderValue(string text)
    {
        _slider.value = float.Parse(text);
    }
}
