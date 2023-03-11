using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour,IInteractableWithPlayer
{
    private Vector3 startPos;
    
    private void Start()
    {
        startPos = transform.position;
    }

    private void OnEnable() => AddListeners();

    private void OnDisable() => RemoveListeners();

   
   private void SetStartPos()
    {
        gameObject.transform.SetParent(null);
        transform.DOMove(startPos, 1);
    }

  

    public void InteractWithPlayer(Player player)
    {
        if(GameManager.Instance.cubeCountOnThePlayer == 0)
        {
            GameManager.Instance.sphereCount++;
            GameManager.Instance.sphereScaleY += transform.localScale.y;
            gameObject.transform.SetParent(player.transform);
            gameObject.transform.localPosition = new Vector3(0, GameManager.Instance.sphereScaleY, 0);
        }
       
    }

    private void AddListeners()
    {
        GameEvents.OnSphereSetStartPos += SetStartPos;
    }

    private void RemoveListeners()
    {
        GameEvents.OnSphereSetStartPos -= SetStartPos;
    }

    
}
