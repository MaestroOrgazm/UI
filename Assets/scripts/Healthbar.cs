using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
[RequireComponent(typeof(Slider))]
[RequireComponent(typeof(Health))]

public class Healthbar : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private TMP_Text _tmpText;
    [SerializeField] private Image _fillImage;

    private Color _currentColor;
    private Color _healColor = Color.green;
    private Color _damageColor = Color.red;
    private Slider _slider;
    private int _recoveryRate = 7;
    private Coroutine _updateBar;
    private Health _health;
    private int _maxHealth;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _health = _player.GetComponent<Health>();
        _slider.value = _health._currentHealth;
        _currentColor = _fillImage.color;
        _maxHealth = _health._maxHealth;
        UpdateText(_health._currentHealth);
    }
    public void ChangeHealth()
    {
        _health.ChangeHealthEvent += RestartCorrutine;
    }

    private IEnumerator UpdateBar(int currentHealth)
    {
        UpdateText(currentHealth);

        while (_slider.value != currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _recoveryRate * Time.deltaTime);


            if (_slider.value > currentHealth)
            {
                _fillImage.color = _damageColor;
            }
            else if (_slider.value < currentHealth)
            {
                _fillImage.color = _healColor;
            }

            yield return new WaitForEndOfFrame();
        }

        _fillImage.color = _currentColor;
        _health.ChangeHealthEvent -= RestartCorrutine;
    }
    private void UpdateText(int currentHealth)
    {
        _tmpText.text = ($"{currentHealth}/{_maxHealth}");
    }

    private void RestartCorrutine(int currentHealth)
    {
        if (_updateBar != null)
        {
            StopCoroutine(_updateBar);
        }

        _updateBar = StartCoroutine(UpdateBar(currentHealth));
    }
}
