using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileMN : MonoBehaviour
{
    public static GameObject _TileMnObj;

    [SerializeField]  Country _county;

    [SerializeField] List<TilePower> oda = new();
    [SerializeField] List<TilePower> imagawa = new();
    [SerializeField] List<TilePower> saitou = new();
    [SerializeField] List<TilePower> takeda = new();
    [SerializeField] List<TilePower> houzyou = new();
    [SerializeField] List<TilePower> satake = new();
    [SerializeField] List<TilePower> uesugi = new();
    [SerializeField] List<TilePower> nannbu = new();
    [SerializeField] List<TilePower> date = new();
    [SerializeField] List<TilePower> mogami = new();
    [SerializeField] List<TilePower> hatakeyama = new();
    [SerializeField] List<TilePower> asakura = new();
    [SerializeField] List<TilePower> asai = new();
    [SerializeField] List<TilePower> rokkaku = new();
    [SerializeField] List<TilePower> matunaga = new();
    [SerializeField] List<TilePower> miyosi = new();
    [SerializeField] List<TilePower> tyousokabe = new();
    [SerializeField] List<TilePower> ootomo = new();
    [SerializeField] List<TilePower> simazu = new();
    [SerializeField] List<TilePower> mouri = new();
    [SerializeField] List<TilePower> kitabatake = new();
    [SerializeField] List<TilePower> amako = new();
    [SerializeField] List<TilePower> asikaga = new();

    private List<TilePower> SelectContry;

    public static GameObject SelectTile;
    public List<GameObject> _PlyertileUI;

    [SerializeField] GameObject _tileStetasImage;
    [SerializeField] public List<Text> _tileMeny;
    [SerializeField] Image _contryFlag;
    //?{?^??
    [SerializeField] GameObject _nextButton;
    [SerializeField] GameObject _closeTileStetasButton;
    [SerializeField] List<GameObject> _building;
    [SerializeField] GameObject _armyUI;

    private string _tileContryName;
    private void Awake()
    {
        _TileMnObj = this.gameObject;
        //_contryFlagRender = _contryFlag.GetComponent<SpriteRenderer>();
    }
    public void Start()
    {
        for (int i = 0; i<23; i++)
        {
            //???̃X?e?[?^?X?̃??Z?b?g?p
            _county.Contry[i].ManpowerChage(9999);
            _county.Contry[i].EconomyChage(9999);
            _county.Contry[i].FoodChage(9999);
            switch (i)
            {
                case 0:
                    SelectContry = oda;
                    foreach (var item in oda)
                    {
                        item._playerTile = true;
                    }
                    break;
                case 1:
                    SelectContry = nannbu;
                    break;
                case 2:
                    SelectContry = date;
                    break;
                case 3:
                    SelectContry = mogami;
                    break;
                case 4:
                    SelectContry = uesugi;
                    break;
                case 5:
                    SelectContry = satake;
                    break;
                case 6:
                    SelectContry = houzyou;
                    break;
                case 7:
                    SelectContry = takeda;
                    break;
                case 8:
                    SelectContry = hatakeyama;
                    break;
                case 9:
                    SelectContry = imagawa;
                    break;
                case 10:
                    SelectContry = saitou;
                    break;
                case 11:
                    SelectContry = asakura;
                    break;
                case 12:
                    SelectContry = asai;
                    break;
                case 13:
                    SelectContry = rokkaku;
                    break;
                case 14:
                    SelectContry = kitabatake;
                    break;
                case 15:
                    SelectContry = asikaga;
                    break;
                case 16:
                    SelectContry = matunaga;
                    break;
                case 17:
                    SelectContry = miyosi;
                    break;
                case 18:
                    SelectContry = tyousokabe;
                    break;
                case 19:
                    SelectContry = amako;
                    break;
                case 20:
                    SelectContry = mouri;
                    break;
                case 21:
                    SelectContry = ootomo;
                    break;
                case 22:
                    SelectContry = simazu;
                                      break;
            }
            foreach (var item in SelectContry)
            {
                _county.Contry[i].ManpowerChage(item.ManPower);
                _county.Contry[i].EconomyChage(item.Economy);
                _county.Contry[i].FoodChage(item.Food);
                item._contryID = i;
            }
        }//???̃X?e?[?^?X????????
    }

    public void TilePlay(bool Player,int contryID, int tileManpower, int tileeconomy, int tileFood)
    {
        if(Player == true)
        {
            _PlyertileUI.ForEach(x => x.gameObject.SetActive(true));
            Debug.Log("?v???C???[?^?C?????????ꂽ");
        }else
            if(Player == false)
        {
            _PlyertileUI.ForEach(x => x.gameObject.SetActive(false));
        }
        _tileContryName = _county.Contry[contryID].Name;
        _contryFlag.sprite = _county.Contry[contryID].CountyrCrest;
        _tileStetasImage.SetActive(true);
        _tileMeny[0].text = "?l????"+tileManpower;
        _tileMeny[1].text = "?o?ϗ͂?" + tileeconomy;
        _tileMeny[2].text = "?H?????Y????" + tileFood;
        _tileMeny[3].text = _tileContryName;
        //_nextButton.SetActive(false)
    }
    public void CloseTileStetas()
    {
        _tileStetasImage.SetActive(false);
    }
    
    public void BildButton()
    {
        if(SelectTile.GetComponent<TilePower>()._playerTile == true&& SelectTile.GetComponent<TilePower>()._TileBuild==false)
        {
            BuildinMN.BuildSrectTile = SelectTile;
            foreach (var item in _building)
            {
                item.SetActive(true);
            }
        }
    }

    public void ArmyButton()
    {
        _armyUI.SetActive(true);
    }
}
