using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GameObject _fill;

    private Color _currentColor;
    private HPtext _hpText;
    private Slider _slider;
    private Color _healColor = Color.green;
    private Color _damageColor = Color.red;
    private Image _image;

    public void GetHeal()
    {
        while(_slider.value < _hpText._currentHealth)
        {
            _image.color = _healColor;
        }

        _image.color = _currentColor;
    }

    public void GetDamage()
    {
        while (_slider.value > _hpText._currentHealth)
        {
            _image.color = _damageColor;
        }

        _image.color = _currentColor;
    }

    private void Start()
    {
        _hpText = GetComponent<HPtext>();
        _slider = GetComponent<Slider>();
        _image = _fill.GetComponent<Image>();
        _currentColor = _image.color;
    }
}
