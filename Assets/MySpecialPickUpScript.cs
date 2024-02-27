using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySpecialPickUpScript : MonoBehaviour
{
    public MyGameManagerScript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<MyGameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.MyAddSpecialPickup();
            Destroy(gameObject);
        }

    }
}
