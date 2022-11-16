using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum PrimitiveNames
{
    Sphere,
    Capsule,
    Cylinder,
    Cube,
    Plane,
    Quad
}

public static class Utilityhelper
{
    public static void CreateObject()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject.CreatePrimitive(PrimitiveType.Capsule);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject.CreatePrimitive(PrimitiveType.Plane);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject.CreatePrimitive(PrimitiveType.Quad);
        }
    }
    public static void CreateObject(Text name)
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject.CreatePrimitive(PrimitiveType.Sphere);
             name.text = PrimitiveNames.Cylinder.ToString();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject.CreatePrimitive(PrimitiveType.Capsule);
            name.text = PrimitiveNames.Capsule.ToString();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            name.text = PrimitiveNames.Cylinder.ToString();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject.CreatePrimitive(PrimitiveType.Cube);
            name.text = PrimitiveNames.Cube.ToString();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject.CreatePrimitive(PrimitiveType.Plane);
            name.text = PrimitiveNames.Plane.ToString();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            GameObject.CreatePrimitive(PrimitiveType.Quad);
            name.text = PrimitiveNames.Quad.ToString();
        }

    }

    public static void ChangePostion(GameObject obj)
    {
        obj.transform.position = new Vector3(Random.value, Random.value, Random.value);
    }
    public static void ChangeColor(GameObject obj)
    {
            obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
    public static void ChangeName
        (GameObject obj)
    {
        obj.transform.position = new Vector3(Random.value, Random.value, Random.value);
    }

}
