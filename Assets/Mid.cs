using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Mid : MonoBehaviour
{
    public static Mid Instance;

    public event EventHandler OnClickMid;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnMouseDown()
    {
        OnClickMid?.Invoke(this, EventArgs.Empty);
    }
}
