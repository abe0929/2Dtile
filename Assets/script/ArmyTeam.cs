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
    [SerializeField] int[] _battalionID;
    public GameObject[] _battalionButton;
    [SerializeField] Sprite[] battalionSprite;
    [SerializeField] GameObject SelectUnit;

    public Battalion _battalion;

    
    public void armyStetas(ArmyPopMN armypop)
    {
        _armyPopMN = armypop;
        Atacktext.text = (""+_armyPopMN._armyAttack);
        HpText.text = (""+_armyPopMN._armyHp);
        CostText.text = ("" + _armyPopMN._armyCost);
        ManpoerText.text = ("" + _armyPopMN._needManpoer);
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
        
    }




}
