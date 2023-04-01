using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Capsule : Shape
{
    private string Name = "Capsule";

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
