using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    //Connect this Script to Game Object Named Part_4,get the Transfom component
    //of Part_4, Part_4_Child using either transform.Get or transform.Find and the
    //transfrom of Part_4_GameObject using GameObject.Find
    //Using transform.name pass the name and position values of each of the Game Objects
    //to PrintOutNameAndPosition. 
    //You should have the results of Part_4, 0,0,0, Part_4_Child -5,-5,-5 and Part_4_GameObject, 5,5,5

    Transform part4Transform;
    Transform part4Child;
    Transform part4Object;

    void Start()
    {
        part4Transform = GetComponent<Transform>();
        part4Child = part4Transform.GetChild(0);
        part4Object = GameObject.Find("Part_4_GameObject").transform;

        PrintOutNameAndPosition(part4Transform.name, part4Transform.position);
        PrintOutNameAndPosition(part4Object.name, part4Object.position);
        PrintOutNameAndPosition(part4Child.name, part4Child.position);
    }

    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
