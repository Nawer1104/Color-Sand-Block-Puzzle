using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Left : MonoBehaviour
{
    public static Left Instance;

    public event EventHandler OnClickLeft;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnMouseDown()
    {
        OnClickLeft?.Invoke(this, EventArgs.Empty);
    }
}
