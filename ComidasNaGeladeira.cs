using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidasNaGeladeira : MonoBehaviour
{
    public GameObject[] foodItems;
    public Inventory playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        foodItems = new GameObject[5];
        GameObject player = GameObject.Find("Player");
        playerInventory = player.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
