using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ItemData : MonoBehaviour
{
    public static UI_ItemData UI_item;

    public int item1;  // 5탄 갯수 
    public int item2; // 7탄 갯수
    public int item3;// 12게이지 갯수
    public int item4;// .45탄 갯수

    public bool i1; // 아이템이 1개 이상인가?
    public bool i2;
    public bool i3;
    public bool i4;

    void Start()
    {


        Debug.Log("hi");
        Debug.Log(UI_item);
    }

    void Update()
    {
        i1 = 0 < item1;
        i2 = 0 < item2;
        i3 = 0 < item3;
        i4 = 0 < item4;

        UI_item = this;
    }
}