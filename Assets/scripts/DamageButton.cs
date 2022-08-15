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

    private Health _health;

    private void Start()
    {
        _health = _slider.GetComponent<Health>();
    }

    public void OnButtonClick()
    {
        _health.GetDamage();
    }
}
