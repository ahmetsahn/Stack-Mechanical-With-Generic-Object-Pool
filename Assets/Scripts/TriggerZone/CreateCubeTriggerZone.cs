using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubeTriggerZone : MonoBehaviour, IInteractableWithPlayer
{
    public void InteractWithPlayer(Player player)
    {
        GameEvents.LoadSphereSetStartPos();
        GameEvents.LoadCreateCube();
        GameManager.Instance.cubeCountOnTheTable += GameManager.Instance.sphereCount;
        GameManager.Instance.sphereCount = 0;
        GameManager.Instance.sphereScaleY = 1;
    }
}
