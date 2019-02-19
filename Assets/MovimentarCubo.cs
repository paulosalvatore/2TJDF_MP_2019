using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentarCubo : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        var velocidade = 5f;
        var acceleration = Input.acceleration;
        transform.Translate(
            acceleration.x * velocidade * Time.deltaTime,
            0,
            -acceleration.z * velocidade * Time.deltaTime
        );
    }
}