using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInputs : MonoBehaviour
{
    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        //Exibir quantidade de toques na tela
        //int quantidadeToques = Input.touchCount;
        //print(quantidadeToques);
        //Debug.Log(quantidadeToques);

        //Exibir aceleração do dispositivo
        //var acceleration = Input.acceleration;
        //print(acceleration);

        //Exibir posição do toque
        //var position = Input.mousePosition;
        //print(position);

        // Exibir posição de todos os toques, utilizando for
        //int quantidadeToques = Input.touchCount;

        //if (quantidadeToques > 0)
        //{
        //    for (int indexTouch = 0; indexTouch < quantidadeToques; indexTouch++)
        //    {
        //        var touch = Input.GetTouch(indexTouch);
        //        var positionTouch = touch.position;
        //        print(
        //            string.Format(
        //                "Touch: {0} - x: {1}, y: {2}",
        //                indexTouch,
        //                positionTouch.x,
        //                positionTouch.y
        //            )
        //        );
        //    }
        //}

        // Exibir posição de todos os toques, utilizando foreach
        Touch[] touches = Input.touches;

        foreach (Touch touch in touches)
        {
            var positionTouch = touch.position;
            print(
                string.Format(
                    "Touch: {0} - TouchPhase: {3} - x: {1}, y: {2}",
                    touch.fingerId,
                    positionTouch.x,
                    positionTouch.y,
                    touch.phase
                )
            );
        }
    }
}