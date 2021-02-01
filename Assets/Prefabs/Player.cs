﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed = 1000f;
    [SerializeField] float directionalSpeed = 2f;
    Rigidbody rgb;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR || UNITY_STANDALONE || UNITY_WEBPLAYER
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position = Vector3.Lerp(transform.position, new Vector3(Mathf.Clamp(transform.position.x + moveHorizontal, -2.5f, 2.5f),
        transform.position.y, transform.position.z), directionalSpeed * Time.deltaTime);
#endif
        rgb.velocity = Vector3.forward * playerSpeed * Time.deltaTime;
        //MOBILE CONTROLS
        Vector2 touch = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 10f));
        if (Input.touchCount > 0)
        {
            transform.position = new Vector3(touch.x, transform.position.y, transform.position.z);
        }
    }
}
