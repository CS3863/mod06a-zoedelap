using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdversaryChaosController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float directionHorizontal;
    private float directionVertical = 1.0f;

    private int changeDelay = 0;
    private int ticks = 0;

    void Update()
    {
        if (ticks == changeDelay) {
            // directionVertical = Random.Range(0.0f, 1.0f);
            directionHorizontal = Random.Range(-1.0f, 1.0f);
            ticks = 0;
            changeDelay = Random.Range(30, 600);
        }
        ticks++;

        // Move the Vehicle forward by vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * directionVertical);
        // Move the Vehicle forward by horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * directionHorizontal);
    }
}
