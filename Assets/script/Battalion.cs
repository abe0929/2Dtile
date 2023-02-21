using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
  fileName = "BattalionData",
  menuName = "ScriptableObject/BattalionData")]
public class Battalion : ScriptableObject
{
    [SerializeField] List<Battalionstatus> _battalion = new();
    public List<Battalionstatus> ST_Battalion => _battalion;
}
[System.Serializable]
public class Battalionstatus
{
    [SerializeField]
    string _name;

    [SerializeField]
    float battalionHp;

    [SerializeField]
    int battalionAtack;

    [SerializeField]
    int battalionCost;

    [SerializeField]
    int MovePoint;
}

