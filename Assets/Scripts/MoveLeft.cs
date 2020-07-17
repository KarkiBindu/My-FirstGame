using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public PlayerController Player;
    public void OnPointerDown(PointerEventData eventData)
    {
        Player.MoveLeft = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Player.MoveLeft = false;
    }
}
