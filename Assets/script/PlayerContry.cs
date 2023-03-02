using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContry : MonoBehaviour
{
    [SerializeField] Country _county;
    [SerializeField] Text _goldTetx;
    [SerializeField] Text _armyManpoerText;
    [SerializeField] Text _foodTetx;

    public int _playerHaveGold = 100;
    private int _playerPlusGold;
    public int _plusGoldBuff = 100;

    private int _playerHaveFood = 10;
    private int _playerPlusFood;
    public int _plusFoodBuff = 100;

    public int _PlayerHaveArmyResources;
    private int _playerPlusArmyResources;
    public int _plusArmyBuff = 100;

    private void Start()
    {
        _PlayerHaveArmyResources = _county.Contry[0].Manpower * 1000;
    }

    private void Update()
    {
        PlayerResouceText();
        PlayerResouse();
    }

    public void PlayerResouceText()
    {
        _goldTetx.text = _playerHaveGold + "+" + _playerPlusGold;
        _armyManpoerText.text = ""+_PlayerHaveArmyResources+ "+" + _playerPlusArmyResources;
        _foodTetx.text = _playerHaveFood + "+" + _playerPlusFood;
    }
    public void PlayerResouse()
    {
        _playerPlusGold = _county.Contry[0].Economy * _plusGoldBuff/100;
        _playerPlusFood = _county.Contry[0].Food * (int)_plusFoodBuff / 100;
        _playerPlusArmyResources = _county.Contry[0].Manpower * (int)_plusArmyBuff / 100 * 100;
    }
    public void TurnResouse()
    {
        _playerHaveGold += _playerPlusGold;
        _playerHaveFood += _playerPlusFood;
        if(_PlayerHaveArmyResources< _county.Contry[0].Manpower * 1000)
        {
            _PlayerHaveArmyResources += _playerPlusArmyResources;
        }
    }
}
