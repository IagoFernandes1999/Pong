using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float velocidade = 0.5f;

    [SerializeField]
    KeyCode upKey = KeyCode.UpArrow;

    [SerializeField]
    KeyCode downKey = KeyCode.DownArrow;
    


    // Update is called once per frame
    void Update()
    {
        /* 
         * se tecla pra cima premida
         * então subir
         * senão se tecla pra baixo premida
         * então descer
         */


        if(Input.GetKey(upKey))
        {
            //Sobe
            //transform.position =
            //    transform.position + velocidade * Vector3.up;

            transform.position += velocidade * Vector3.up * Time.deltaTime;

        } else if (Input.GetKey(downKey))
        {

            //Desce
            // transform.position =
            //     transform.position + velocidade * Vector3.down;

            transform.position += velocidade * Vector3.down * Time.deltaTime;
        }

        float cameraheight = Camera.main.orthographicSize;
        float halfPaddleSize = 0.5f;

        //if(transform.position.y >= cameraheight- halfPaddleSize)
        //na pratica o codigo abaixo faz
        //transform.position.y = 3f - 0.5f
        //{
        //Vector3 positionAux = transform.position;
        //positionAux.y = cameraheight - halfPaddleSize;
        //transform.position = positionAux;
        //}
        //if (transform.position.y <= -cameraheight + halfPaddleSize)
        //na pratica o codigo abaixo faz
        //transform.position.y = -3f  0.5f
        //{
        //Vector3 positionAux = transform.position;
        //positionAux.y = -cameraheight + halfPaddleSize;
        //transform.position = positionAux;
        //}

        Vector3 positionAux = transform.position;
        positionAux.y = Mathf.Clamp(transform.position.y, -cameraheight + halfPaddleSize, cameraheight - halfPaddleSize);
        transform.position = positionAux;

    }
}
