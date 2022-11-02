using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Points.instance.AddPoint();
    }
}
