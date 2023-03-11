using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class GenericObjectPool<T> : MonoBehaviour where T : Component
{
    public static GenericObjectPool<T> Instance { get; private set; }

    [SerializeField]
    private T prefab;

    public List<T> objectPool = new List<T>();

    private float objectScaleY;

    

    private void Awake()
    {
        Instance = this;
    }
    
    public T Get(Transform transform)
    {
        if (objectPool.Count == 0)
        {
            AddObjects(transform);
        }

        var firstObject = objectPool.First();
        objectPool.Remove(firstObject);
        
        return firstObject;
    }


    public void ReturnToPool(T objectToReturn,int count)
    {  
         objectToReturn.gameObject.SetActive(false);
         objectPool.Insert(objectPool.Count - count, objectToReturn);
    }

    private void AddObjects(Transform transform)
    {
        T newObject = Instantiate(prefab);
        newObject.gameObject.SetActive(false);
        objectPool.Add(newObject);
        objectScaleY += newObject.transform.localScale.y;
        newObject.transform.position = new Vector3(transform.position.x, transform.position.y + objectScaleY, transform.position.z);
        newObject.transform.SetParent(transform);
    }
}
