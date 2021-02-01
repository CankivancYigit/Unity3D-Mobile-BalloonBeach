using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [Tooltip("Distance Between Camera And Player")][SerializeField] float distanceCameraPlayer = 10f;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, player.transform.position.z - distanceCameraPlayer), Time.deltaTime * 100f); 
    }
}
