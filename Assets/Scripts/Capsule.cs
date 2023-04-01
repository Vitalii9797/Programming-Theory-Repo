using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    private string Name = "Capsule";

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
