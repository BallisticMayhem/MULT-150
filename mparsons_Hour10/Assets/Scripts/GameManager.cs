using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange, SChaos;
    private bool isGameOver = false;
    private float elapsedTime = 0f;
    private bool timerRunning = false;

    void Start()
    {
        timerRunning = true; // Start the stopwatch when the game begins
    }

    void Update()
    {
        // Tick the stopwatch if the game isn't over
        if (timerRunning && !isGameOver)
        {
            elapsedTime += Time.deltaTime;
        }

        // If all 5 goals are solved then the game is over
        bool allSolved = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && SChaos.isSolved;

        if (allSolved && !isGameOver)
        {
            isGameOver = true;
            timerRunning = false; // Stop the stopwatch on completion
        }
    }

    void OnGUI()
    {
        // Format elapsed time as MM:SS.mm
        int minutes = (int)(elapsedTime / 60f);
        int seconds = (int)(elapsedTime % 60f);
        int milliseconds = (int)((elapsedTime * 100f) % 100f);
        string timeString = string.Format("{0:00}:{1:00}.{2:00}", minutes, seconds, milliseconds);

        // Always show the stopwatch in the top-left corner
        Rect timerRect = new Rect(10, 10, 150, 30);
        GUI.Box(timerRect, "Time: " + timeString);

        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }
}