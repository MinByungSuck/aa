using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    static public int CurrentHP = 100;
    public int speed;
    public GameObject Player;

     private Vector3 MouseDirection;
     private Vector3 Direction;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CurrentHP);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CurrentHP -= 10;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
        ViewControl();
    }
    void ViewControl()
    {
        /*Direction = Input.mousePosition - Player.transform.position;
        float angle = Vector3.Angle(Direction.normalized, Vector3.up);
            if(Input.mousePosition.x > Player.transform.position.x)
        {
            angle = 360f - angle;
        }

        Vector3 euler = new Vector3(0f, 0f, angle);
        Player.transform.rotation = Quaternion.Euler(euler);
    \*/
        Direction = Input.mousePosition - Player.transform.position;
        Player.transform.up = Direction.normalized;
    }
}
