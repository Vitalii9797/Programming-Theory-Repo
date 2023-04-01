using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    private string Name = "Sphere";

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
