using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Cube : Shape
{
    private string Name = "Cube";

    private MainManager mainManager;
    private void Start()
    {
        mainManager = MainManager.instance;

        AssignShape();
    }

    //POLYMORPHISM
    protected override void AssignShape()
    {
        mainManager.AddShape(Name);
    }
}
