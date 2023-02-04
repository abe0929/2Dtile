using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ArmyMove : MonoBehaviour, IPointerClickHandler
{
    public int _movePoint;
    public GameObject _nowTile;
    private TilePower _tilePower;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        print("soto");
        switch (pointerEventData.pointerId)
        {
            case -1:
                _tilePower = _nowTile.GetComponent<TilePower>();
                _tilePower.SetStep(_movePoint);
                print("aa");
                break;
            case -2:
                
                break;
            case -3:
                
                break;
        }
    }
}
