using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeladeiraAção : MonoBehaviour
{
    public GameObject objectToToggle;
    public float detectionRadius = 2f;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, objectToToggle.transform.position);
        if (Input.GetKeyDown(KeyCode.Z) && distance <= detectionRadius)
        {
            objectToToggle.SetActive(!objectToToggle.activeSelf);
            Debug.Log("Player apertou Z");
        }
    }
}

