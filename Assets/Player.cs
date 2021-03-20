using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, (float)0.05);
        //}
        //if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        //{
        //    transform.position += new Vector3(0, (float)-0.05);
        //}
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3((float)-0.05, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3((float)0.05, 0);
        }
    }
}
