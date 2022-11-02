using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;
    public Text points;
    int score = 0;
    public int total = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        points.text = "Score:" + score.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        points.text = "Score:" + score.ToString();
    }
    void Update()
    {

    }
}
