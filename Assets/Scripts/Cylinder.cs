using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private string Name = "Cylinder";

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
