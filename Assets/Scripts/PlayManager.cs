using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private bool[] playground = new bool[10];
    private IDictionary<int, IGrid> gridController = new Dictionary<int, IGrid>();

    public void setPlayground(int index, bool value)
    {
        playground[index] = value;
    }
    public bool getPlayground(int index)
    {
        return playground[index];
    }

    public void setGridController(int index, IGrid value)
    {
        gridController[index] = value;
    }

    public IGrid getGridController(int index)
    {
        return gridController[index];
    }

    public void resetPlayground()
    {
        for (int i = 0; i < playground.Length; i++)
        {
            playground[i] = false;
        }
    }

    public void resetGridController()
    {
        for (int i = 0; i < gridController.Count; i++)
        {
            gridController[i].Init();
        }
    }

}
