using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField]private List<DrawTile> tiles = new List<DrawTile>();
    private float thickness = 12;
    public Color pathColor;
    private LineRenderer lr;
    private void Start()
    {
        lr = GetComponent<LineRenderer>();
        gameObject.GetComponent<LineBetweenObjects>().SetObjects(lr, tiles, pathColor);
        for (int i = 0; i < tiles.Count; i++)
        {
            tiles[i].tileColor = pathColor;
            if (i == 0 || i == tiles.Count - 1) tiles[i].number = tiles.Count;
            else tiles[i].number = 0;
            tiles[i].Paint();
        }
    }


    //private void OnDrawGizmos()
    //{
    //    if (tiles.Any())
    //    {
    //        for (int i = 0; i < tiles.Count - 1; i++)
    //        {
    //            tiles[i].tileColor = pathColor;
    //            tiles[i+1].tileColor = pathColor;
    //            Handles.DrawBezier(tiles[i].transform.position, tiles[i + 1].transform.position, tiles[i].transform.position, tiles[i + 1].transform.position, pathColor, null, thickness);
    //            Handles.DrawBezier(tiles[i].transform.position, tiles[i + 1].transform.position, tiles[i].transform.position, tiles[i + 1].transform.position, pathColor, null, thickness);
    //        }
    //    }
    //}
}
