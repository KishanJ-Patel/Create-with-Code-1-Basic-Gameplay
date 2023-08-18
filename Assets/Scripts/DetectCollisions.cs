using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
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
        GameObject scoreboardManager = GameObject.FindGameObjectWithTag("ScoreboardManager");

        if (gameObject.CompareTag("Projectile"))
        {
            if (other.gameObject.CompareTag("Animal")) Destroy(gameObject);
        }
        else if (gameObject.CompareTag("Animal"))
        {
            if (other.gameObject.CompareTag("Projectile")) scoreboardManager.GetComponent<ScoreboardManager>().increaseScore();
            else if (other.gameObject.CompareTag("Player")) scoreboardManager.GetComponent<ScoreboardManager>().decreaseLives();
            Destroy(gameObject);
        }
    }
}
