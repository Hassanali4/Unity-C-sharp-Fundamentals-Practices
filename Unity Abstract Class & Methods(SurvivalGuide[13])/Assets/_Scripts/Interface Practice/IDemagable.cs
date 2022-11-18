using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDemagable
{
    int Health { get; set; }

    void Demage(int demageAmount);
}
