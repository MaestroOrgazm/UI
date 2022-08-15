using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ChangeColor))]

public class Healthbar : MonoBehaviour
{
    private HPtext _hpText;
    private Slider _slider;
    private int _recoveryRate = 5;
    private ChangeColor _changeColor;

    private void Start()
    {
        _hpText = GetComponent<HPtext>();
        _slider = GetComponent<Slider>();
        _changeColor = GetComponent<ChangeColor>();
        _slider.value = _hpText._currentHealth;
    }

    public void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _hpText._currentHealth, _recoveryRate * Time.deltaTime);


        if (_slider.value > _hpText._currentHealth)
        {
            _changeColor.GetDamage();
        }
        else if (_slider.value < _hpText._currentHealth)
        {
            _changeColor.GetHeal();
        }
        else
        {
            _changeColor.ReturnColor();
        }
    }
}
