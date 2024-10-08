using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsOther : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // When other object collides into object, destroy other object
        Destroy(other.gameObject);
    }
}
