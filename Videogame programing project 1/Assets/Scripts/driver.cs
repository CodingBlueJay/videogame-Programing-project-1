using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour {
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20;
    [SerializeFeild]  float slowSpeed = 15;
    [SerializeFeild] float boostSpeed = 30f;

    void Start()
    {
        
    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;

       float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

       transform.Rotate(0, 0, -steerAmount);
       transform.Translate(0, moveAmount, 0);
    }
}