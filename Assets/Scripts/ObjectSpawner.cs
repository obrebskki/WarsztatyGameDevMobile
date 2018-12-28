using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    private Vector3 first_spawn;
    
    private float distance_between_spawning;

    [SerializeField]
    [Range(0f,20f)]
    private float renderer_frequency;

    

    void Start () {
        first_spawn = new Vector3(0, 2.2f,0);
        distance_between_spawning = -10f;
    }
	 
	// Update is called once per frame
	void FixedUpdate () {

        if(player.transform.position.y > distance_between_spawning )
        {
            ObjectPooler.Instance.SpawnFromPool("Circle", first_spawn);
            first_spawn.y += renderer_frequency;
            ObjectPooler.Instance.SpawnFromPool("Circle", first_spawn);
            first_spawn.y += renderer_frequency;
            distance_between_spawning += renderer_frequency*2;           
        }
        
    }
}
