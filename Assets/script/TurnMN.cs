using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TurnMN : MonoBehaviour
{
    public static int _nowTurn;
    [SerializeField] Text _turnText;
    [SerializeField] PlayerContry _turnresouce ;
    [SerializeField] List<int> _buildCompleteTurn;
    [SerializeField] List<GameObject> _buildCompleteTile;
    [SerializeField] List<GameObject> _humerObj;
    [SerializeField] List<int> _buildID;
    [SerializeField] Building _building;
    private void Start()
    {
        _nowTurn = 0;
    }
    public void NextTurn()
    {
        _nowTurn += 1;
        _turnText.text =_nowTurn + "É^Å[Éìñ⁄";
        for ( int i = 0; i< _buildCompleteTurn.Count; i++) 
        { 
            if(_nowTurn == _buildCompleteTurn[i])
            {
                Instantiate(_building.Buiding[_buildID[i]].BuildImage, _buildCompleteTile[i].transform.position, Quaternion.identity);
                _turnresouce._plusGoldBuff += _building.Buiding[_buildID[i]].GoldBuffl;
                _turnresouce._plusFoodBuff += _building.Buiding[_buildID[i]].FoodBuff;
                _turnresouce._plusArmyBuff += _building.Buiding[_buildID[i]].ArmyBuff;
                _humerObj[i].SetActive(false);
                _humerObj.RemoveAt(i);
                _buildCompleteTurn.RemoveAt(i);
                _buildCompleteTile.RemoveAt(i);
                _buildID.RemoveAt(i);                
            }
        }
        _turnresouce.TurnResouse();
    }
    public void BuildTile(int needTurn,GameObject buildTile,int buildID,GameObject hunmerObj)
    {
        _buildCompleteTurn.Add(needTurn+ _nowTurn);
        _buildCompleteTile.Add(buildTile);
        _buildID.Add(buildID);
        _humerObj.Add(hunmerObj);
    }
}
