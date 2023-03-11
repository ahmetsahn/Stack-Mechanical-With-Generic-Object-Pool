using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float sphereScaleY;
    public int sphereCount;
    public int cubeCountOnTheTable;
    public int cubeCountOnThePlayer;



    private void Awake()
    {
        Instance = this;

        sphereScaleY = 1;
    }
}
