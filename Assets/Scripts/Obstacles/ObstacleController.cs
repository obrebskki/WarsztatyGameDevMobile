using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    [SerializeField]
    private float rotatingSpeed = 1;
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotatingSpeed));

    }
}
