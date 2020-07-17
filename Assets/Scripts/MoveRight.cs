using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRight : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public PlayerController Player;
   
    public void OnPointerDown(PointerEventData eventData)
    {
        Player.MoveRight = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Player.MoveRight = false;
    }
}
