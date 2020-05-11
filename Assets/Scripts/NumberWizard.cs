using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    string welcomeMessage = "Welcome to Number Wizard, Player";
    string instructionMessage = "Welcome to Number Wizard, Player";
    int maxNumber;
    int minNumber;
    int guess;

    void Start()
    {
        startScene();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            nextGuess();
        }

        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            minNumber = guess;
            nextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your answer is " + guess + "!");
            startScene();
        }
    }

    void startScene()
    {
        maxNumber = 1000;
        minNumber = 0;

        guess = (maxNumber + minNumber) / 2;
        Debug.Log(welcomeMessage);
        Debug.Log(instructionMessage);
        Debug.Log("The Highest number you can pick is: " + maxNumber);
        Debug.Log("The Lowest number you can pick is: " + minNumber);
        Debug.Log("Is your number higher or lower than " + guess + " ?");
        Debug.Log("Higher -> Up arrow key, Lower -> Down arrow key, Correct -> Enter");
        maxNumber += 1;
    }

    void nextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is your number higher or lower than " + guess + "?");
    }
}
