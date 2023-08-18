using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float lowerBound = -10f;
    [SerializeField] private float sideBound = 30f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        // Remove game object if it goes past bounds
        if (transform.position.z > topBound 
            || transform.position.z < lowerBound
            || transform.position.x > sideBound
            || transform.position.x < -sideBound)
        {
            Destroy(gameObject);
        }
    }
}
