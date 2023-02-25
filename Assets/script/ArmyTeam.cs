using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyTeam : MonoBehaviour
{
    ArmyPopMN _armyPopMN;
    [SerializeField] Text Atacktext;
    [SerializeField] Text HpText;
    [SerializeField] Text CostText;
    [SerializeField] Text ManpoerText;
    [SerializeField] Text MovePointText;
    [SerializeField] int[] _battalionID;
    public GameObject[] _battalionButton;
    [SerializeField] Sprite[] battalionSprite;
    [SerializeField] GameObject SelectUnit;

    public Battalion _battalion;
    private int _SelectBattalion;
    [SerializeField] GameObject _armyUnitButton;

    [SerializeField] int _allHp;//hpÇÃçáåv
    [SerializeField] int _jumlahBatalyon;//ëÂë‡ÇÃêî
    [SerializeField] int _armyHp;//hpÇÃçáåvÇëÂë‡ÇÃêîÇ≈äÑÇ¡ÇΩêîÅ@ïΩãœ
    [SerializeField] int _armyAtack;
    [SerializeField] int _armyManpower;
    [SerializeField] int _armyCost;
    [SerializeField] int _movePoint;
    public void armyStetas(ArmyPopMN armypop)//armyPopÇÃèÓïÒÇéÊìæ
    {
        _armyPopMN = armypop;
        _allHp = _armyPopMN._allHp;
        _jumlahBatalyon = _armyPopMN._jumlahBatalyon;
        _armyHp = _armyPopMN._armyHp;
        _armyAtack = _armyPopMN._armyAttack;
        _armyManpower = _armyPopMN._needManpoer;
        _armyCost = _armyPopMN._armyCost;
        _movePoint = _armyPopMN._movePoint;
        TextChenzi();
    }

    public void TextChenzi()
    {
        HpText.text = ("" + _armyHp);
        Atacktext.text = ("" + _armyAtack);
        CostText.text = ("" + _armyCost);
        ManpoerText.text = ("" + _armyManpower);
        MovePointText.text = ("" + _movePoint);

    }

    public void battalion(GameObject ArmyUnit,int[] battalionID)
    {
        SelectUnit = ArmyUnit;
        _battalionID = battalionID;

        for (int i = 0; i < 9; i++)
        {
            _battalionButton[i].GetComponent<Image>().sprite = battalionSprite[_battalionID[i]];
        }
    }
    public void SelectButton(int PosN)
    {
        _SelectBattalion = PosN;
        _armyUnitButton.SetActive(true);
    }
    public void SelectArmyButton(int armyID)
    {
        int oldArmyID = _battalionID[_SelectBattalion];
        _battalionID[_SelectBattalion] = armyID;
        _battalionButton[_SelectBattalion].GetComponent<Image>().sprite = _battalion.ST_Battalion[armyID].ArmySprite;
        if (armyID != 4)
        {
            _allHp += _battalion.ST_Battalion[armyID].BattalionHp;
            _jumlahBatalyon++;
            _armyHp = _allHp / _jumlahBatalyon;
            _armyAtack += _battalion.ST_Battalion[armyID].BattalionAtack;
            _armyManpower += _battalion.ST_Battalion[armyID].BattalionManpower;
            _armyCost += _battalion.ST_Battalion[armyID].BattalionCost;
            if (_movePoint >= _battalion.ST_Battalion[armyID].MovePoint)
            {
                _movePoint = _battalion.ST_Battalion[armyID].MovePoint;
            }
            if (oldArmyID != 4)
            {
                _allHp -= _battalion.ST_Battalion[oldArmyID].BattalionHp;
                _armyHp = _allHp / _jumlahBatalyon;
                _armyAtack -= _battalion.ST_Battalion[oldArmyID].BattalionAtack;
                _armyManpower -= _battalion.ST_Battalion[oldArmyID].BattalionManpower;
                _armyCost -= _battalion.ST_Battalion[oldArmyID].BattalionCost;
            }

        }else
        {
            if (oldArmyID != 4)
            {
                _allHp -= _battalion.ST_Battalion[oldArmyID].BattalionHp;
                _jumlahBatalyon--;
                _armyHp = _allHp / _jumlahBatalyon;
                _armyAtack -= _battalion.ST_Battalion[oldArmyID].BattalionAtack;
                _armyManpower -= _battalion.ST_Battalion[oldArmyID].BattalionManpower;
                _armyCost -= _battalion.ST_Battalion[oldArmyID].BattalionCost;
            }
        }
        TextChenzi();
        _armyUnitButton.SetActive(false);
    }
}
