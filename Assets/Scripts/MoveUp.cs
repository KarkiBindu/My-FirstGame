using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveUp : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public PlayerController Player;
   
    public void OnPointerDown(PointerEventData eventData)
    {
        Player.MoveUp = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Player.MoveUp = false;
    }
}
