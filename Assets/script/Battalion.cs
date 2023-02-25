using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public string Name => _name;
    public int BattalionHp => _battalionHp;
    public int BattalionAtack => _battalionAtack;
    public int BattalionCost => _battalionCost;
    public int BattalionManpower => _battalionManpower;
    public int MovePoint => _movePoint;

    public Sprite ArmySprite => _armySprite;

    [SerializeField]
    string _name;

    [SerializeField]
    int _battalionHp;

    [SerializeField]
    int _battalionAtack;

    [SerializeField]
    int _battalionManpower;

    [SerializeField]
    int _battalionCost;

    [SerializeField]
    int _movePoint;

    [SerializeField]
    Sprite _armySprite;
}

