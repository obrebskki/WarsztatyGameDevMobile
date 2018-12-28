using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private Transform player;

    [SerializeField]
    private Vector3 offset;

    private float position_y = 1.5f;

    private float smoothness = 0.05f;

    void LateUpdate()
    {   
        Vector3 updated_position = player.position + offset;
        if (updated_position.y > (transform.position.y + position_y) )
        {
            Vector3 smooth_positioning = Vector3.Lerp(transform.position, updated_position, smoothness);
            transform.position = smooth_positioning;
        }     
    }
}

