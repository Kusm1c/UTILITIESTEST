using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singletons<T> : MonoBehaviour where T : class
{
    public static T Instance;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this as T;
        DontDestroyOnLoad(gameObject);
    }
}

public class Pool<T> where T : Object
{
    public readonly Queue<T> pool = new Queue<T>();
    public readonly T defaultItem;

    public Pool(T defaultItem)
    {
        this.defaultItem = defaultItem;
    }

    public void AddToPool(T ItemToAdd)
    {
        if (ItemToAdd is GameObject t)
            t.SetActive(false);
        pool.Enqueue(ItemToAdd);
    }

    public T GetFromPool()
    {
        return (pool.Count == 0) ? pool.Dequeue() : Object.Instantiate(defaultItem);
    }

    public IEnumerator AddToPoolAfterTime(T ItemToAdd, float time)
    {
        yield return new WaitForSeconds(time);
        AddToPool(ItemToAdd);
    }
}