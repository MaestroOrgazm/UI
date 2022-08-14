using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonAnimation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private RectTransform _rTransform;
    private Vector3 _defaultScale;
    private Vector3 _enter = new Vector3(0.9f, 0.9f, 0.9f);

    private void Start()
    {
        _rTransform = GetComponent<RectTransform>();
        _defaultScale = _rTransform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _rTransform.localScale = _enter;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _rTransform.localScale = _defaultScale;
    }
}
