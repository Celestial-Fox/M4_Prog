using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounter : MonoBehaviour
{
    [SerializeField] private int score = 0;
    [SerializeField] private List<string> coins = new List<string>();

    int listNumber = 0;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Collect The Wahoo Coins!!!");
        }
    }

    void Update()
    {
        if (score >= 50)
        {
            Debug.Log("You Win!");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            addCoin(1);
        }
    }

        void addCoin(int coinValue)
        {
            score += coinValue;
            Debug.Log("Wahoo Coin!");
            coins.Add("coin " + listNumber);
            Debug.Log("You Now Have " + coins.Count + " Wahoo Coins!");
        listNumber++;
        }
}
