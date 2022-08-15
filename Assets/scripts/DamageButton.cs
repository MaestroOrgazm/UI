using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;


[RequireComponent (typeof(Slider))]

public class DamageButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private HPtext _hpText;

    private void Start()
    {
        _hpText = _slider.GetComponent<HPtext>();
    }

    public void OnButtonClick()
    {
        _hpText.GetDamage();
    }
}
