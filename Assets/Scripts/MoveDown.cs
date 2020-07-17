using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveDown : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public PlayerController Player;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Player.MoveDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Player.MoveDown = false;
    }
}
