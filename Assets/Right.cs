using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Right : MonoBehaviour
{
    public static Right Instance;

    public event EventHandler OnClickRight;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnMouseDown()
    {
        OnClickRight?.Invoke(this, EventArgs.Empty);
    }
}
