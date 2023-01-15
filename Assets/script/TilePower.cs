using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePower : MonoBehaviour
{
    public int ManPower => _manpower;
    public int Economy => _economy;
    public int Food => _food;

    public bool _playerTile = false;
    
    [SerializeField]
    public int _manpower = 1;
    [SerializeField]
    private int _economy = 1;
    [SerializeField]
    private int _food = 1;

    public void ClickTile()
    {
        TileMN._TileMnObj.GetComponent<TileMN>().TilePlay(_playerTile);
    }
}
