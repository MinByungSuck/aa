using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Bullet : MonoBehaviour {
    public Text ScoreText;

    public int CurrentBullet; //장전되어있는 총알 수
    public int OwnBullet;      // 가지고 있는 총알 수

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.text =CurrentBullet.ToString() + " | "+ OwnBullet.ToString();
    }


}
