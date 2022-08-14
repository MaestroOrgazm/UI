using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private HPtext _hpText;
    private Slider _slider;
    private int _recoveryRate = 5;

    public void Update()
    {
        _slider.value = Mathf.MoveTowards(_slider.value, _hpText._currentHealth, _recoveryRate * Time.deltaTime);
        _hpText.UpdateText();
    }

    private void Start()
    {
        _hpText = GetComponent<HPtext>();
        _slider = GetComponent<Slider>();
        _slider.value = _hpText._currentHealth;
    }
}
