using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonEnter : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] UISound sound;
    public void OnPointerEnter(PointerEventData eventData)
    {
        sound.PlayUITouchSound();
    }
}
