using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleInstantiatePoint : MonoBehaviour
{
    private void OnEnable() => AddListeners();

    private void OnDisable() => RemoveListeners();

    private void GetCapsule()
    {
        var newCapsule = CapsulePool.Instance.Get(transform);
        newCapsule.gameObject.SetActive(true);
    }

    private void CreateCapsule()
    {
        for (int i = 0; i < GameManager.Instance.cubeCountOnThePlayer; i++)
        {
            GetCapsule();
        }

    }

    private void AddListeners()
    {
        GameEvents.OnCreateCapsule += CreateCapsule;
     
    }

    private void RemoveListeners()
    {
        GameEvents.OnCreateCapsule -= CreateCapsule;
    }
}
