using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    //ENCAPSULATION
    public static MainManager instance { get; private set; }

    [SerializeField] private Text cubeText;
    [SerializeField] private Text sphereText;
    [SerializeField] private Text capsuleText;
    [SerializeField] private Text cylinderText;

    private int cubesCount, spheresCount, capsulesCount, cylinderCount;

    private void Awake()
    {
        if(instance == null) instance = this;
    }
    
    public void AddShape(string shapeName)
    {
        switch(shapeName)
        {
            case "Cube":
                cubesCount++;
                cubeText.text = ($"Cubes: {cubesCount}");
                break;
            case "Sphere":
                spheresCount++;
                sphereText.text = ($"Spheres: {spheresCount}");
                break;
            case "Cylinder":
                cylinderCount++;
                cylinderText.text = ($"Cylinders: {cylinderCount}");
                break;
            case "Capsule":
                capsulesCount++;
                capsuleText.text = ($"Capsules: {capsulesCount}");
                break;
        }
    }
}
