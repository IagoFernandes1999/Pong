using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField]
    ScoreKeeper scoreKeeper;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreKeeper.Goal();
    }
}
