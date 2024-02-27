using UnityEngine;

public class MyPickUpScript : MonoBehaviour
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
            gameManager.AddScore();
            Destroy(gameObject);
        }
    }
}
