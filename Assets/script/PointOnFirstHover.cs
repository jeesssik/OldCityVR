using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PointOnFirstHover : MonoBehaviour
{
    private bool alreadyCounted = false;

    public void RegisterHover()
    {
        if (alreadyCounted) return;

        alreadyCounted = true;

        if (ObjectCounterManager.Instance != null)
        {
            ObjectCounterManager.Instance.AddPoint();
        }
    }
}

