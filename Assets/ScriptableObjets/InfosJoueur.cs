using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InfosJoueur", menuName ="SO/InfosJoueur")]
public class InfosJoueur : ScriptableObject
{
    public string nomJoueur;
    public int pointDeVies;
    public int pointage;
}