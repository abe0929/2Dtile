using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyPopMN : MonoBehaviour
{
    /*memo
    大隊ID　
      　　　槍兵=0
    　　　　弓兵=1
            騎兵=2
          弓騎兵=3
            無し=4
    */
    public Sprite[] _armyIDsprite;
    public int[] _battalionID;//1から9まで割り当て

    [SerializeField] ArmyTeam _armyTeam;
    [SerializeField] PlayerContry _playerContry;
    [SerializeField] GameObject _armyPhb;
    public ArmyMove _armyMove;
    public ArmyMN _armyMN;
    public int _allHp;
    public int _allSpeed;
    public int _jumlahBatalyon;
    public int _armyAttack = 0;
    public int _armyHp = 0;
    public int _armyCost=0;
    public int _needManpoer=0;
    public int _movePoint =2;
    public string _armyName;

    private void Start()
    {
       for(int i =0; i< 9; i++)
        {
            _battalionID[i] = 4;//大隊IDを無しにする
        }
    }
    public void ArmyButtonTeam()
    {
        _armyTeam.gameObject.SetActive(true);
        _armyTeam.armyStetas(this);
        _armyTeam.battalion(this.gameObject, _battalionID);
    }

    public void ArmyPopButton()
    {
        if(_jumlahBatalyon == 0)
        {
            return;
        }
        print("呼ばれはした");
        if (_playerContry._playerHaveGold >= _armyCost && _playerContry._PlayerHaveArmyResources >= _needManpoer)
        {
            _playerContry._playerHaveGold -= _armyCost;
            _playerContry._PlayerHaveArmyResources -= _needManpoer;

            GameObject army;
            army = Instantiate(_armyPhb, TileMN.SelectTile.transform.position, Quaternion.identity);
            _armyMove = army.GetComponent<ArmyMove>();
            _armyMove._nowTile = TileMN.SelectTile;
            _armyMove._movePoint = _movePoint;
            _armyMove._armyAttack = _armyAttack;
            _armyMove._armyHp = _armyHp;
            _armyMove._armyMN = _armyMN;
        }
        else
            print("なんかたりない");
    }
}


