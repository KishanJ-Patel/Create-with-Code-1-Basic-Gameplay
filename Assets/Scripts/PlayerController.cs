using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float xRange = 10.0f;
    [SerializeField] private float zRange = 12.0f;

    [SerializeField] private GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        keepPlayerInRange();

        moveHorizontal();

        moveVertical();


        // Launch projectiles from the player location
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }

    private void keepPlayerInRange()
    {
        // Restrict movement past the range 
        float clampedX = Mathf.Clamp(transform.position.x, -xRange, xRange);
        float clampedZ = Mathf.Clamp(transform.position.x, 0, zRange);

        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }

    private void moveHorizontal()
    {
        // Get horizontal input and move the player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }

    private void moveVertical()
    {
        // Get horizontal input and move the player
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
