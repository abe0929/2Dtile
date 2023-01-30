using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(
  fileName = "BuildingData",
  menuName = "ScriptableObject/BuildingData")]
public class Building : ScriptableObject
{
    [SerializeField] List<BuildingDate> _building = new();
    public List<BuildingDate> Buiding => _building;
}
[System.Serializable]
public class BuildingDate
{
    public int NeedCost => _needCost;
    public int NeedTurn => _needTurn;
    public int GoldBuffl => _goldBuffl;
    public int FoodBuff => _foodBuffl;
    public int ArmyBuff => _armyBuffl;

    public GameObject BuildImage => _buildImage;

    [SerializeField]
    string _name;
    [SerializeField]
    int _needCost;
    [SerializeField]
    int _needTurn;
    [SerializeField]
    int _goldBuffl;
    [SerializeField]
    int _foodBuffl;
    [SerializeField]
    int _armyBuffl;
    [SerializeField]
    GameObject _buildImage;
    public string NameChange(string name)
    {
        _name = name;
        return _name;
    }
}
