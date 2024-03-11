using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverKeyTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _keySpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LeverOne" + "LeverTwo")
        {
            Debug.Log("LeverOne and LeverTwo have triggered");
            _keySpawn.SetActive(true);
        }
    }
}
