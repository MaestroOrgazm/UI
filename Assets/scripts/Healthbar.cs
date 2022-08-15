using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Image _fillImage;

    private Color _currentColor;
    private Color _healColor = Color.green;
    private Color _damageColor = Color.red;
    private Health _health;
    private Slider _slider;
    private int _recoveryRate = 7;

    private void Start()
    {
        _health = GetComponent<Health>();
        _slider = GetComponent<Slider>();
        _slider.value = _health._currentHealth;
        _currentColor = _fillImage.color;
    }

    public IEnumerator UpdateBar()
    {
        while (_slider.value != _health._currentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _health._currentHealth, _recoveryRate * Time.deltaTime);


            if (_slider.value > _health._currentHealth)
            {
                _fillImage.color = _damageColor;
            }
            else if (_slider.value < _health._currentHealth)
            {
                _fillImage.color = _healColor;
            }

            yield return new WaitForEndOfFrame();
        }

        _fillImage.color = _currentColor;
    }
}
