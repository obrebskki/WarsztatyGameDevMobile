using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    private Vector3 spawn_position;
    
    private float spawning_distance;

    [SerializeField]
    [Range(0f,20f)]
    private float renderer_distance;

    

    void Start () {
        spawn_position = new Vector3(0, 2.2f,0);
        spawning_distance = -10f;
    }
	 
	// Update is called once per frame
	void FixedUpdate () {

        if(player.transform.position.y > spawning_distance )
        {
            ObjectPooler.Instance.SpawnFromPool("Circle", spawn_position);
            spawn_position.y += renderer_distance;
            spawning_distance += renderer_distance;           
        }
        
    }
}
