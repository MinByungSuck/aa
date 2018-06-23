using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Survivor : MonoBehaviour
{

    public int Survivor_Amout; // 살아있는 생존자 수

    public Text ScoreText;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "생존 : " + Survivor_Amout.ToString();
    }

}

