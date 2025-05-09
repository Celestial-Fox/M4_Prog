using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private float jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.position += Vector3.forward * speed *Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = 10;
        } else
        {
            speed = 5;
        }

        /*
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            transform.position += Vector3.up * jump;
        }
        */
    }
}
