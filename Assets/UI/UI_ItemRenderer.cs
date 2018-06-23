using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_ItemRenderer : MonoBehaviour
{

    public Text ItemText;
    public int itemNum;


    public Image ItemImage;
    private bool IsOwn; //아이템을 가지고 있는가?
    // Use this for initialization
    void Start()
    {
        ItemImage = gameObject.GetComponent<Image>();
        Debug.Log(UI_ItemData.UI_item.GetComponent<UI_ItemData>().i1);



    }

    // Update is called once per frame
    void Update()
    {
        if (itemNum.Equals(1))
        {
            IsOwn = UI_ItemData.UI_item.GetComponent<UI_ItemData>().i1;
            ItemText.text = UI_ItemData.UI_item.GetComponent<UI_ItemData>().item1.ToString();
        }
        if (itemNum.Equals(2))
        {
            IsOwn = UI_ItemData.UI_item.GetComponent<UI_ItemData>().i2;
            ItemText.text = UI_ItemData.UI_item.GetComponent<UI_ItemData>().item2.ToString();
        }
        if (itemNum.Equals(3))
        {
            IsOwn = UI_ItemData.UI_item.GetComponent<UI_ItemData>().i3;
            ItemText.text = UI_ItemData.UI_item.GetComponent<UI_ItemData>().item3.ToString();
        }
        if (itemNum.Equals(4))
        {
            IsOwn = UI_ItemData.UI_item.GetComponent<UI_ItemData>().i4;
            ItemText.text = UI_ItemData.UI_item.GetComponent<UI_ItemData>().item4.ToString();
        }

        if (!IsOwn)
            ItemImage.color = new Color(255, 255, 255, 0.7f);
        if (IsOwn)
            ItemImage.color = new Color(255, 255, 255, 1);
        //spriteRenderer.color = new Color32(255, 255, 255, 255);


    }
}
