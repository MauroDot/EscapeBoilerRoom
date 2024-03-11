using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingID : MonoBehaviour
{
    [SerializeField]
    int _clothingID;

    public int GetClothingID()
    {
        return _clothingID;
    }
}
