using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TileSetting : MonoBehaviour
{

	[ContextMenu("AddTileCell")]
	public void AddTileCell()
	{
		var mastGameObject = GetComponentsInChildren<Transform>().Select(t => t.gameObject);

		foreach (Transform child in transform)
		{
			if (!child.GetComponent<TilePower>())
			{
				child.gameObject.AddComponent<TilePower>();
			}
		}
	}

	[ContextMenu("remove")]
	public void RemoveTileCell()
	{
		foreach (Transform child in transform)
		{
			if (child.GetComponent<TilePower>())
			{
				DestroyImmediate(child.gameObject.GetComponent<TilePower>());
			}
		}
	}

	[ContextMenu("SetRelationCell")]
	public void TileCellSetRelations()
	{
		var cells = GetComponentsInChildren<TilePower>();
		foreach (var cell in cells)
		{
			cell.SetRelation(cells.ToList());
		}
	}

}