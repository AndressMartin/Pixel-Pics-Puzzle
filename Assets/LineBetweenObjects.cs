using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LineBetweenObjects : MonoBehaviour
{
    private List<Transform> points = new List<Transform>();
    [SerializeField] private List<Vector3> positions = new List<Vector3>();
    private LineRenderer lr;

    public void SetObjects(LineRenderer lr, List<DrawTile> objects, Color color)
    {
        this.lr = lr;
        lr.positionCount = objects.Count;
        lr.startColor = color;
        lr.endColor = color;
        foreach (var obj in objects)
        {
            points.Add(obj.transform);
            positions.Add(obj.transform.position);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (lr != null)
        {
            for (int i = 0; i < points.Count; i++)
            {
                lr.SetPosition(i, points[i].position);
            }
        }
        
    }
}