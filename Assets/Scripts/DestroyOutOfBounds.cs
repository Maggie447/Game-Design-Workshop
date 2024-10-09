using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 10;
    private float lowerBound = -7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player's view in game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // If an object goes behind the player, remove that object
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
