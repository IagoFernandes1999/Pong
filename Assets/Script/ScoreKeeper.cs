using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int leftScore = 0;
    int rightScore = 0;

    public void Goal()
    {
        leftScore = leftScore + 1;
        rightScore = rightScore + 1;
        Debug.Log(leftScore + "" + rightScore);
    }

}

