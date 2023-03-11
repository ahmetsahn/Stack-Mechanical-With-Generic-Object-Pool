using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCapsuleTriggerZone : MonoBehaviour, IInteractableWithPlayer
{
    public void InteractWithPlayer(Player player)
    {
        GameEvents.LoadReturnToPoolCube(GenericObjectPool<Cube>.Instance.objectPool.Count);
        GameEvents.LoadDeactiveCube();
        GameEvents.LoadCreateCapsule();
        GameManager.Instance.cubeCountOnThePlayer = 0;

    }

}
