using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    private void OnEnable() => AddListeners();

    private void OnDisable() => RemoveListeners();


    private void ReturnToPool(int objectPoolCount)
    {
        CapsulePool.Instance.ReturnToPool(this,objectPoolCount);
    }

    private void AddListeners()
    {
        GameEvents.OnReturnToPoolCapsule += ReturnToPool;
    }

    private void RemoveListeners()
    {
        GameEvents.OnReturnToPoolCapsule -= ReturnToPool;
    }
}
