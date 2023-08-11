using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    
    [SerializeField] private float cooldown = 3.0f;

    private float cooldownCount = 0f;

    // Update is called once per frame
    void Update()
    {
        if (cooldownCount > 0) cooldownCount -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldownCount <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            cooldownCount = cooldown;
        }
    }
}
