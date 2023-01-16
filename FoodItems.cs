using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItems : MonoBehaviour
{
    public GameObject[] foodItems;


    // Start is called before the first frame update
    void Start()
    {
        foodItems = new GameObject[5];

        foodItems[0] = GameObject.Find("Café");
        foodItems[1] = GameObject.Find("Leite");
        foodItems[2] = GameObject.Find("Ovo");
        foodItems[3] = GameObject.Find("Queijo");
        foodItems[4] = GameObject.Find("Açúcar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
