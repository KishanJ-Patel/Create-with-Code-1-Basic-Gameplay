using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardManager : MonoBehaviour
{
    [SerializeField] private int playerLives = 3;
    private int score = 0;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Player's Lives = {playerLives}");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void decreaseLives()
    {
        if (!isGameOver)
        {
            Debug.Log($"Player's Lives = {--playerLives}");
            if (playerLives <= 0)
            {
                Debug.Log("Game Over");
                isGameOver = true;
            }
        }
    }

    public void increaseScore()
    {
        if (!isGameOver) Debug.Log($"Score = {++score}");
    }
}
