using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(
  fileName = "StatusData",
  menuName = "ScriptableObject/StatusData")]
public class Country : ScriptableObject
{
    [SerializeField] List<status> _contry = new();

    public List<status> Contry  => _contry;

}
[System.Serializable]
public class status
{
    public string Name => _name;

    public int Manpower => _manpower;


    [SerializeField]
    string _name;

    [SerializeField]
    string _colorcode;

    [SerializeField]
    int _manpower = 0;

    [SerializeField]
    int _Economy = 0;

    [SerializeField]
    int _food = 0;

    
    public string NameChange(string name)
    {
        _name = name;
        return _name;
    }

    public int ManpowerChage(int power)
    {
        if(power == 9999)
        {
            _manpower = 0;
        }
        else
        _manpower += power;
        return _manpower;
    }
    public int EconomyChage(int power)
    {
        if (power == 9999)
        {
            _Economy = 0;
        }
        else
            _Economy += power;
        return _Economy;
    }
    public int FoodChage(int power)
    {
        if (power == 9999)
        {
            _food = 0;
        }
        else
            _food += power;
        return _food;
    }

}
