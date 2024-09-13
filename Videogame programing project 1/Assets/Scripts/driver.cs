using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour {
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 20;
    [SerializeField]  float slowSpeed = 15;
    [SerializeField] float boostSpeed = 30f;

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