using UnityEngine;
using TMPro;
using System.Collections;

[RequireComponent(typeof(TMP_Text))]

public class Health : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmpText;

    public int _currentHealth { get; private set; } = 50;
    private int _maxHealth = 100;
    private int _minHealth = 0;
    private int _changeValue = 10;
    private Coroutine _updateBar;
    private Healthbar _healthbar;

    private void Start()
    {
        _healthbar = GetComponent<Healthbar>();
        UpdateText();
    }

    public void GetHeal()
    {
        _currentHealth += _changeValue;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        UpdateText();
        RestartCorrutine();
    }
    public void GetDamage()
    {
        _currentHealth -= _changeValue;

        if (_currentHealth < _minHealth)
        {
            _currentHealth = _minHealth;
        }

        UpdateText();
        RestartCorrutine();
    }

    private void UpdateText()
    {
        _tmpText.text = ($"{_currentHealth}/{_maxHealth}");
    }

    private void RestartCorrutine()
    {
        if (_updateBar != null)
        {
            StopCoroutine(_updateBar);
        }

        _updateBar = StartCoroutine(_healthbar.UpdateBar());
    }
}
