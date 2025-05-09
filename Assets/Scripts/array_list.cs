using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array_list : MonoBehaviour
{
    [SerializeField] private int[] points = { 4, 5, 6, 7 };
    [SerializeField] private List<int> coins = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(points[0]);
        Debug.Log(points[1]);
        Debug.Log(points[2]);
        Debug.Log(points[3]);

        coins.Add(5);
        coins.Add(6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
