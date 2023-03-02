using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class ArmyMove : MonoBehaviour, IPointerClickHandler
{
    public static GameObject _selectMoveUnit;
    public int _movePoint;
    public GameObject _nowTile;
    private TilePower _tilePower;
    [SerializeField] public ArmyMN _armyMN;
    [SerializeField] Country _country;
    bool _armyMove = true;
    bool _armyMoveEnd = false;

    public int _armyAttack;
    public int _armyHp;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        print("soto");
        switch (pointerEventData.pointerId)
        {
            case -1:
                if (_armyMove == true)
                {
                    _tilePower = _nowTile.GetComponent<TilePower>();
                    _tilePower.SetStep(_movePoint);
                    _selectMoveUnit = this.gameObject;
                    _armyMove = false;
                }
                else if(_armyMoveEnd == false)
                {
                    foreach (var item in ArmyMN._moveTile)
                    {
                        TilePower _tilePower = item.GetComponent<TilePower>();
                        _tilePower.nowStep = -1;
                        _tilePower._armyMove = false;
                        string colarCode = _country.Contry[_tilePower._contryID].Colorcode;
                        print(colarCode);

                        Color newColor;
                        if (ColorUtility.TryParseHtmlString("#" + colarCode, out newColor))
                            item.GetComponent<SpriteRenderer>().color = newColor;
                    }
                    _armyMove = true;
                }
                break;
            case -2:
                break;
            case -3:
                break;
        }
    }

    public void MoveEnd(GameObject nowTile)
    {
        if (_armyMove == false)
        {
            print("moveEnd‚ª‚æ‚Î‚ê‚½");
            _nowTile = nowTile;

            foreach (var item in ArmyMN._moveTile)
            {
                TilePower _tilePower = item.GetComponent<TilePower>();
                _tilePower.nowStep = -1;
                _tilePower._armyMove = false;
                string colarCode = _country.Contry[_tilePower._contryID].Colorcode;
                print(colarCode);

                Color newColor;
                if (ColorUtility.TryParseHtmlString("#" + colarCode, out newColor))
                    item.GetComponent<SpriteRenderer>().color = newColor;
            }
            _armyMoveEnd = true;
        }
    }
}
