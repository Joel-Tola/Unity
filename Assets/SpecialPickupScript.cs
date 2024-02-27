using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialPickupScript : MonoBehaviour
{
    public GameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.AddSpecialPickup();
            Destroy(gameObject);
        }

    }
}
