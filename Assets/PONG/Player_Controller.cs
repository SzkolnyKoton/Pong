using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed =5f;
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upKey))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }

        if (Input.GetKey(downKey))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
    }
}
