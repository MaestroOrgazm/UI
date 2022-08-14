using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TMP_Text))]

public class HPtext : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmpText;

    public int _currentHealth { get; private set; } = 50;
    private int _maxHealth = 100;
    private int _minHealth = 0;
    private int _changeValue = 10;

    public void GetHeal()
    {
        _currentHealth += _changeValue;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        UpdateText();
    }
    public void GetDamage()
    {
        _currentHealth -= _changeValue;

        if (_currentHealth < _minHealth)
        {
            _currentHealth = _minHealth;
        }

        UpdateText();
    }
    private void UpdateText()
    {
        _tmpText.text = ($"{_currentHealth}/{_maxHealth}");
    }

    private void Start()
    {
        UpdateText();
    }
}
