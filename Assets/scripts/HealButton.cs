using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private HPtext _hpText;

    public void OnButtonClick()
    {
        _hpText.GetHeal();
    }

    private void Start()
    {
        _hpText = _slider.GetComponent<HPtext>();
    }
}
