using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TilePower : MonoBehaviour,IPointerClickHandler
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

    public void OnPointerClick(PointerEventData eventData)
    {
        TileMN._TileMnObj.GetComponent<TileMN>().TilePlay(_playerTile, _manpower,_economy,_food);
    }
    
}
