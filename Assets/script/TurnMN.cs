using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMN : MonoBehaviour
{
    public static int _nowTurn;
    [SerializeField] PlayerContry _turnresouce ;
    private void Start()
    {
        _nowTurn = 0;
    }
    public void NextTurn()
    {
        _nowTurn += 1;
        _turnresouce.TurnResouse();
    }
}
