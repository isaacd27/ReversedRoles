using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy",menuName = "Enemies")]
public class Enemy : ScriptableObject
{
    public string Name;
    public Sprite Fig;
    public int HP;
    public int Attack;
    public int Defense;


}
