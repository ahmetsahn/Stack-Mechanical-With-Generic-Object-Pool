using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    private void OnEnable() => AddListeners();

    private void OnDisable() => RemoveListeners();


    private void ReturnToPool(int objectPoolCount)
    {
        CubePool.Instance.ReturnToPool(this,objectPoolCount);
    }

    private void AddListeners()
    {
        GameEvents.OnReturnToPoolCube += ReturnToPool;   
    }

    private void RemoveListeners()
    {
        GameEvents.OnReturnToPoolCube -= ReturnToPool;
    }

}
