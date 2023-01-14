using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CharaGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject CharaPrefab;

    [SerializeField]
    private Grid grid;

    private Vector3Int gridPos;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gridPos = grid.WorldToCell(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            GameObject chara = Instantiate(CharaPrefab, gridPos, Quaternion.identity);

            chara.transform.position = new Vector2(chara.transform.position.x + 0.0f, chara.transform.position.y + 0.0f);
        }
    }
}
