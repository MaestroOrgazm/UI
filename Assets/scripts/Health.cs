using UnityEngine;
using System.Collections;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    public event UnityAction<int> ChangeHealthEvent;
    public int _currentHealth { get; private set; } = 50;
    public int _maxHealth { get; private set; } = 100;
    private int _minHealth = 0;

    public void ChangeHealth(int damage)
    {
        _currentHealth += damage;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        else if (_currentHealth < _minHealth)
        {
            _currentHealth = _minHealth;
        }

        ChangeHealthEvent?.Invoke(_currentHealth);
    }
}
