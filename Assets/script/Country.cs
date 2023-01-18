using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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

    public Sprite CountyrCrest => _countyrCrest;

    public int Manpower => _manpower;

    public int Economy => _economy;

    public int Food => _food;

    [SerializeField]
    string _name;

    [SerializeField]
    string _colorcode;

    [SerializeField]
    int _manpower = 0;

    [SerializeField]
    int _economy = 0;

    [SerializeField]
    int _food = 0;

    [SerializeField]
    Sprite _countyrCrest;





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
            _economy = 0;
        }
        else
            _economy += power;
        return _economy;
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
