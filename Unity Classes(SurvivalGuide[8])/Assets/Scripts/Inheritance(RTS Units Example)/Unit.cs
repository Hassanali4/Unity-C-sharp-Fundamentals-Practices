using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Unit
{
    public string name;
    public int health;
    public float movingSpeed;
    public Sprite icon;
    [SerializeField]
    private GameObject _model;
    public bool dead;
}
