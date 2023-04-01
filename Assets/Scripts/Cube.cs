using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private string Name = "Cube";

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
