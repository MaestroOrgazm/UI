using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

[RequireComponent (typeof(Health))]
[RequireComponent (typeof(Slider))]
[RequireComponent (typeof(Healthbar))]

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Color _selectedColor;
    [SerializeField] private Slider _slider;

    private Image _image;
    private Color _defaultColor;
    private int _delta = 1;
    private Health _health;
    private int _changeValue = 10;
    private Healthbar _healthbar;


    private void Start()
    {
        _healthbar = _slider.GetComponent<Healthbar>();
        _health = _player.GetComponent<Health>();
        _image = GetComponent<Image>();
        _defaultColor = _image.color;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _image.color = Color.Lerp(_defaultColor, _selectedColor, _delta);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _image.color = Color.Lerp(_image.color, _defaultColor, _delta);
    }

    public void TakeHeal()
    {
        _health.ChangeHealth(_changeValue);
        _healthbar.ChangeHealth();
    }

    public void TakeDamage()
    {
        _health.ChangeHealth(-_changeValue);
        _healthbar.ChangeHealth();
    }
}
