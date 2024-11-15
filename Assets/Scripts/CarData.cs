using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCarData", menuName = "Car/CarData")]
public class CarData : ScriptableObject
{
    [Header("Car Info")]
    public float speed;
    public float size;
    public Color color;

}
