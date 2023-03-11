using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEvents : MonoBehaviour
{
    public static UnityAction OnSphereSetStartPos;
    public static UnityAction OnCreateCube;
    public static UnityAction OnTakeCube;
    public static UnityAction<int> OnReturnToPoolCube;
    public static UnityAction OnDeactiveCube;
    public static UnityAction OnCreateCapsule;
    public static UnityAction<int> OnReturnToPoolCapsule;

    public static void LoadSphereSetStartPos()
    {
        OnSphereSetStartPos?.Invoke();
    }

    public static void LoadCreateCube()
    {
        OnCreateCube?.Invoke();
    }

    public static void LoadTakeCube()
    {
        OnTakeCube?.Invoke();
    }

    public static void LoadReturnToPoolCube(int count)
    {
        OnReturnToPoolCube?.Invoke(count);
    }

    public static void LoadDeactiveCube()
    {
        OnDeactiveCube?.Invoke();
    }

    public static void LoadCreateCapsule()
    {
        OnCreateCapsule?.Invoke();
    }

    public static void LoadReturnToPoolCapsule(int count)
    {
        OnReturnToPoolCapsule?.Invoke(count);
    }




}
