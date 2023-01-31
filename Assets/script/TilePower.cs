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
    public bool _TileBuild = false;

    public int _contryID;

    [SerializeField] int _needMoveCost;
    
    [SerializeField]
    public int _manpower = 1;
    [SerializeField]
    public int _economy = 1;
    [SerializeField]
    public int _food = 1;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        switch (pointerEventData.pointerId)
        {
            case -1:
                Debug.Log("Left Click");
                TileMN._TileMnObj.GetComponent<TileMN>().TilePlay(_playerTile, _contryID, _manpower, _economy, _food);
                TileMN.SelectTile = this.gameObject;
                Debug.Log($"{name}");
                break;
            case -2:
                Debug.Log("Right Click");
                break;
            case -3:
                Debug.Log("Middle Click");
                break;
        }
    }
    
}
