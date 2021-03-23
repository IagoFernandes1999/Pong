using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float Velocidade = 5f;
    float TempoInicial = 0f;
    float TempoDeDisparoDaBola = 2f;
    bool BolaDisparada = false;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        TempoInicial = TempoInicial + Time.deltaTime;

        if (BolaDisparada == false)
        {
            if (TempoDeDisparoDaBola <= TempoInicial)
            {
                GetComponent<Rigidbody2D>().velocity = Velocidade * Random.onUnitSphere;
                BolaDisparada = true;
            }
        }
    }
}
