using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    private string Name = "Sphere";

    private MainManager mainManager;
    private void Start()
    {
        mainManager = MainManager.instance;

        AssignShape();
    }

    protected override void AssignShape()
    {
        mainManager.AddShape(Name);
    }
}
