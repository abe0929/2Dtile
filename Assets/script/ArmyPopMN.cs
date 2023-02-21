using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmyPopMN : MonoBehaviour
{
    /*memo
    ���ID�@
      �@�@�@����=0
    �@�@�@�@�|��=1
            �R��=2
          �|�R��=3
             �����@4
    */
    public Sprite[] _armyIDsprite;
    public Image[] _battalionImage;
    public int[] _battalionID;//1����9�܂Ŋ��蓖��

    [SerializeField] ArmyTeam _armyTeam;

    public int _armyAttack = 0;
    public int _armyHp = 0;
    public int _armyCost=0;
    public int _needManpoer=0;
    public string _armyName;

    private void Start()
    {
       for(int i =0; i< 9; i++)
        {
            _battalionID[i] = 4;//���ID�𖳂��ɂ���
        }
    }
    public void ArmyButtonTeam()
    {
        _armyTeam.gameObject.SetActive(true);
        _armyTeam.armyStetas(this);
        _armyTeam.battalion(this.gameObject, _battalionID);
    }
}


