using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour {

    public Image Hpbar;
	// Use this for initialization
	void Start () {
        Hpbar.fillAmount = 1;

    }
	
	// Update is called once per frame
	void Update () {
        Hpbar.fillAmount = (player.CurrentHP * 0.01f);
	}


}
