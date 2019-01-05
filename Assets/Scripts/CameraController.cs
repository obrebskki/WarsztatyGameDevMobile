using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private Transform player;

    [SerializeField]
    private Vector3 offset;

    private Vector3 velocity = Vector3.zero;

    private float position_y = 0.5f;

    private float smoothness = 0.15f;

    void FixedUpdate()
    {   
        Vector3 updated_position = player.position + offset;
        if (updated_position.y > (transform.position.y + position_y) )
        {
           //transform.position = updated_position;
           Vector3 smooth_positioning = Vector3.SmoothDamp(transform.position, updated_position,ref velocity,smoothness);
           transform.position = smooth_positioning;
           //TODO I think there is sth bad with speed 
        }     
    }
}

