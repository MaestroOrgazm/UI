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

    public void OnPointerDown(PointerEventData eventData)
    {
        _image.color = Color.Lerp(_defaultColor, _selectedColor, 1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _image.color = Color.Lerp(_image.color, _defaultColor, 1);
    }

    private void Start()
    {
        _image = GetComponent<Image>();
        _defaultColor = _image.color;
    }
}
