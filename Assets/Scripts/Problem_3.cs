using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_3 : MonoBehaviour
{
    //Call your function with no parameter and call it with "Game Dev is the best!" 
    void Start()
    {
        Printer();
        Printer("Game Dev is the best!");
    }

    //Create a void function called Printer that takes in one string parameter. 
    //Give this parameter a default value of "This is a default value"
    //Make the function print out the parameter. 
    public void Printer(string word = "This is a default value")
    {
        print(word);
    }
}
