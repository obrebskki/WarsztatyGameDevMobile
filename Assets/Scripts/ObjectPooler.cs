using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    [SerializeField]
    private Dictionary<string, Queue<GameObject>> poolDictionary;

    [SerializeField]
    List<Pool> pools;

    public static ObjectPooler Instance;

    public void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach(Pool pool in pools)
        {
            Queue<GameObject> objects = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objects.Enqueue(obj);
            }
            poolDictionary.Add(pool.tag, objects);
        }

    }

    public void SpawnFromPool (string tag, Vector3 position)
    {
        if(poolDictionary.ContainsKey(tag))
        {
            GameObject spawningObject = poolDictionary[tag].Dequeue();
            spawningObject.SetActive(true);
            spawningObject.transform.position = position;
            poolDictionary[tag].Enqueue(spawningObject);
        }
        else
        {
            Debug.LogWarning("Pool with this tag:" + tag + "doesn't exists");
        }
    }
}
