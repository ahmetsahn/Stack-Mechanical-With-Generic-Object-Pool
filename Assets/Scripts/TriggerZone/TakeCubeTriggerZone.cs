using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeCubeTriggerZone : MonoBehaviour, IInteractableWithPlayer
{
    public void InteractWithPlayer(Player player)
    {
        GameManager.Instance.cubeCountOnThePlayer = GameManager.Instance.cubeCountOnTheTable;
        GameManager.Instance.cubeCountOnTheTable = 0;
        GameEvents.LoadTakeCube();
    }
}
