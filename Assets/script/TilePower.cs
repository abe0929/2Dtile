using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class TilePower : MonoBehaviour, IPointerClickHandler
{
    public int ManPower => _manpower;
    public int Economy => _economy;
    public int Food => _food;

    public bool _playerTile = false;
    public bool _TileBuild = false;

    public bool _armyMove = false;

    public int _contryID;

    public int needStep = 1;
    public int nowStep = -1;

    [SerializeField]
    public int _manpower = 1;
    [SerializeField]
    public int _economy = 1;
    [SerializeField]
    public int _food = 1;

    [SerializeField]
    internal List<TilePower> borderOnTiles;

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
                if(_armyMove == true)
                {
                    ArmyMove._selectMoveUnit.transform.position = this.gameObject.transform.position;
                    ArmyMove._selectMoveUnit.GetComponent<ArmyMove>().MoveEnd(this.gameObject);
                }
                Debug.Log("Right Click");
                break;
            case -3:
                Debug.Log("Middle Click");
                break;
        }
    }

    public void SetRelation(List<TilePower> cells)
    {
        borderOnTiles.Clear();
        foreach (var cell in cells)
        {
            if (cell == this)
            {
                continue;
            }

            float distance = Vector3.Distance(cell.transform.position, this.transform.position);
            if (distance < 1.1f)
            {
                borderOnTiles.Add(cell);
            }
        }
    }

    public virtual void SetStep(int count)
    {
        if (count < 0 || nowStep >= count /*|| _armyRock == true*/)
        {
            return;
        }    
        nowStep = count;
        print("カウントは" + count);
        //gameObject.GetComponent<Renderer>().material.color = Color.white;
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        _armyMove = true;
        //_armyRock =true;
        foreach (var tile in borderOnTiles)
        {
            var nextStepCount = count - tile.needStep;
            tile.SetStep(nextStepCount);
        }
        if (ArmyMN._moveTile.Contains(this.gameObject) == true)
        {
            return;//配列の中に同じオブジェクトがあったら返す
        }
        else ArmyMN._moveTile.Add(this.gameObject);
    }
}
