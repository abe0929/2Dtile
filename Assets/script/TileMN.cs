using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMN : MonoBehaviour
{
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

    public void Start()
    {
       
        int asikagaManpower = 0;
        foreach (var item in oda)
        {
             asikagaManpower += item.ManPower;
            _county.Contry[0].PowerChage(item.ManPower);

        }
    }
}
