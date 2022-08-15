using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]

public class HealButton : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Health _health;

    private void Start()
    {
        _health = _slider.GetComponent<Health>();
    }

    public void OnButtonClick()
    {
        _health.GetHeal();
    }
}
