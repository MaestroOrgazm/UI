using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Color _selectedColor;

    private Image _image;
    private Color _defaultColor;
    private int _delta = 1;

    private void Start()
    {
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
}
