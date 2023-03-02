using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyMN : MonoBehaviour
{
    public static List<GameObject> _moveTile;
    public List<GameObject> _TestMoveTile;

    public void Start()
    {
        _moveTile = new List<GameObject>();
    }
    private void Update()
    {
        if(_moveTile != null)
        {
            _TestMoveTile = _moveTile;
        }

    }
    
}
