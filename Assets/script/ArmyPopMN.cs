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
             無し　4
    */
    public Sprite[] _armyIDsprite;
    public Image[] _battalionImage;
    public int[] _battalionID;//1から9まで割り当て

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
            _battalionID[i] = 4;//大隊IDを無しにする
        }
    }
    public void ArmyButtonTeam()
    {
        _armyTeam.gameObject.SetActive(true);
        _armyTeam.armyStetas(this);
        _armyTeam.battalion(this.gameObject, _battalionID);
    }
}


