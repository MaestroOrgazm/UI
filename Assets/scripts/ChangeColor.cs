using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private GameObject _fill;

    private Color _currentColor;
    private Color _healColor = Color.green;
    private Color _damageColor = Color.red;
    private Image _image;

    private void Start()
    {
        _image = _fill.GetComponent<Image>();
        _currentColor = _image.color;
    }

    public void GetHeal()
    {
        _image.color = _healColor;
    }

    public void GetDamage()
    {
        _image.color = _damageColor;
    }

    public void ReturnColor()
    {
        _image.color = _currentColor;
    }
}
