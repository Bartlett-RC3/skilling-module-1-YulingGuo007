using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Session_2_Yuling : MonoBehaviour
{
    // Colour Names Array
    string[] colours = { "red", "green", "blue", "yellow", "brown" };

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug Log(colours[1]); 

        // LOOPS
        // For loop(counter, end condition, step)

        for (int counter = 0; counter < colours .Length; counter = counter +1)
        {
            Log("The current color at pos" + counter);
            Log(" " + colours[counter]);
        }

        int sum0f0ddNumber = 0;
        for (int i = 1; i < 100, i = i + 2 )
        {
            sum0f0ddNumber += i;
        }
        Log("All odd numbers to 100 added together is:" + sum0f0ddNumber);

        //Shorthand for loop
        foreach (string currentColour in colours )
        {
            Log("Going over the rainbow with " + currentColour);
        }
        // While loop (needs a condition to end)
        int whileCounter = 0;
        string rainbow = "Rainbow colours: ";
        while (whileCounter < colours .Length )
        {
            rainbow += colours[whileCounter] + ",";
            whileCounter += 2;
            
        }
        Log(rainbow);

        // CONDITIONALS (asking the computer questions)

        // If statement (has 2 branches, one for true, one for false, false branch is optional)
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Log("Whole number:" + i);
            }
            else
            {
                Log("Odd number" + i);
            }
        }

        // Asking multiple questions
        bool question1Answer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        // Two conditions met (Concatenation)

        if (question1Answer && question2Answer )
        {
            Log("Both answers are true");
        }

        // More than 2 questions
        if (question1Answer || question2Answer || question3Answer)
        {
            // Action here
        }

        // Question in question
        if(question1Answer == true)
        {
            if (question2Answer == true)
            {
                if (question3Answer == false)
                {
                    // Action here
                }
            }
        }       
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
