using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class CubeInstantiatePoint : MonoBehaviour
{

    [SerializeField]
    private Transform player;

    private Vector3 startPos;

    private void OnEnable() => AddListeners();

    private void OnDisable() => RemoveListeners();


    private void Start()
    {
        startPos = transform.position;
    }


    private void GetCube()
    {
        var newCube = CubePool.Instance.Get(transform);
        newCube.gameObject.SetActive(true);   
    }

    private void CreateCube()
    {
        for (int i = 0; i < GameManager.Instance.sphereCount; i++)
        {
            GetCube();
        }
        
    }

    private void SetParentPlayer()
    {
        transform.SetParent(player);
        transform.DOLocalMove(new Vector3(0, 1, 0),1);
       
    }

    private void SetStartPos()
    {
        transform.SetParent(null);
        transform.position = startPos;
    }

    
    private void AddListeners()
    {
        GameEvents.OnCreateCube += CreateCube;
        GameEvents.OnTakeCube += SetParentPlayer;
        GameEvents.OnDeactiveCube += SetStartPos;
    }

    private void RemoveListeners()
    {
        GameEvents.OnCreateCube -= CreateCube;
        GameEvents.OnTakeCube -= SetParentPlayer;
        GameEvents.OnDeactiveCube -= SetStartPos;
    }


}
