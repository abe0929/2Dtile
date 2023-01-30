using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildinMN : MonoBehaviour
{
    [SerializeField] TileMN _tileMN;
    [SerializeField] Country _country;
    [SerializeField] Building _building;
    [SerializeField] GameObject _BuildButtonBack;
    [SerializeField] PlayerContry _playerContry;
    public static GameObject BuildSrectTile;
    [SerializeField] TurnMN _turnMN;
    [SerializeField] GameObject hammerImage;
    private GameObject hunmerObj;
    public void BuildButtan(int num )
    {
        switch (num)
        {
            case 0:
                _BuildButtonBack.gameObject.SetActive(false);
                break;

            case 1:
                if (_playerContry._playerHaveGold >= _building.Buiding[num -1].NeedCost)
                {
                   _playerContry._playerHaveGold -= _building.Buiding[num - 1].NeedCost;
                    hunmerObj = Instantiate(hammerImage, BuildSrectTile.transform.position, Quaternion.identity);
                    BuildSrectTile.GetComponent<TilePower>()._TileBuild = true;
                    _turnMN.BuildTile(_building.Buiding[num - 1].NeedTurn, BuildSrectTile.gameObject, num-1, hunmerObj);
                    _BuildButtonBack.SetActive(false);
                }
                break;

            case 2:
                if (_playerContry._playerHaveGold >= _building.Buiding[num - 1].NeedCost)
                {
                    _playerContry._playerHaveGold -= _building.Buiding[num - 1].NeedCost;
                    hunmerObj = Instantiate(hammerImage, BuildSrectTile.transform.position, Quaternion.identity);
                    BuildSrectTile.GetComponent<TilePower>()._TileBuild = true;
                    _turnMN.BuildTile(_building.Buiding[num - 1].NeedTurn, BuildSrectTile.gameObject, num - 1, hunmerObj);
                    _BuildButtonBack.SetActive(false);
                }
                    break;
            case 3:

                if (_playerContry._playerHaveGold >= _building.Buiding[num - 1].NeedCost)
                {
                    _playerContry._playerHaveGold -= _building.Buiding[num - 1].NeedCost;
                    hunmerObj = Instantiate(hammerImage, BuildSrectTile.transform.position, Quaternion.identity);
                    BuildSrectTile.GetComponent<TilePower>()._TileBuild = true;
                    _turnMN.BuildTile(_building.Buiding[num - 1].NeedTurn, BuildSrectTile.gameObject, num - 1, hunmerObj);
                    _BuildButtonBack.SetActive(false);
                }
                    break;
        }
    }
    public void KaihatuButtan(int num)
    {
        switch (num)
        {
            case 0://人口
                float needManpowerCost = 10*Mathf.Pow(1.5f, TileMN.SelectTile.GetComponent<TilePower>()._manpower);
                print(needManpowerCost);
                if (_playerContry._playerHaveGold >= needManpowerCost)
                {
                    _playerContry._playerHaveGold -= (int)needManpowerCost;
                    TileMN.SelectTile.GetComponent<TilePower>()._manpower += 1;
                    _tileMN._tileMeny[0].text = "人口は" + TileMN.SelectTile.GetComponent<TilePower>()._manpower;
                    _country.Contry[0].ManpowerChage(1);
                }
                break;

            case 1:
                float needEconomyCost = 10*Mathf.Pow(1.5f, TileMN.SelectTile.GetComponent<TilePower>()._economy);
                print(needEconomyCost);
                if (_playerContry._playerHaveGold >= needEconomyCost)
                {
                    _playerContry._playerHaveGold -= (int)needEconomyCost;
                    TileMN.SelectTile.GetComponent<TilePower>()._economy += 1;
                    _tileMN._tileMeny[1].text = "経済力は" + TileMN.SelectTile.GetComponent<TilePower>()._economy;
                    _country.Contry[0].EconomyChage(1);
                }
                break;
            case 2:
                float needFoodCost = 10 * Mathf.Pow(1.5f, TileMN.SelectTile.GetComponent<TilePower>()._food);
                print(needFoodCost);
                if (_playerContry._playerHaveGold >= needFoodCost)
                {
                    _playerContry._playerHaveGold -= (int)needFoodCost;
                    TileMN.SelectTile.GetComponent<TilePower>()._food += 1;
                    _tileMN._tileMeny[2].text = "食料生産量は" + TileMN.SelectTile.GetComponent<TilePower>()._food;
                    _country.Contry[0].FoodChage(1);
                }
                break;



        }
    }
}
