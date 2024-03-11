using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverID : MonoBehaviour
{
    [SerializeField] int _leverID;

    public int GetLeverID()
    {
        return _leverID;
    }
}
