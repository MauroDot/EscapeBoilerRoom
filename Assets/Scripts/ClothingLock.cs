using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class ClothingLock : MonoBehaviour
{
    [SerializeField] int[] _lockCode = new int[3] { 1, 2, 3 };
    int[] _enteredCode = { 0, 0, 0 };

    private XRSocketInteractor[] _interactors;
    [SerializeField] UnityEvent _onCheck;

    private void Start()
    {
        _interactors = GetComponentsInChildren<XRSocketInteractor>();
    }

    public void EnterSocket0()
    {
        var interactables = _interactors[0].interactablesSelected;
        ClothingID id = interactables[0]?.transform.GetComponent<ClothingID>();
        if (id != null)
        {
            _enteredCode[0] = id.GetClothingID();
            if (CheckCode())
                _onCheck.Invoke();
            Debug.Log("Socket 0 entered");
        }
    }

    public void EnterSocket1()
    {
        var interactables = _interactors[1].interactablesSelected;
        ClothingID id = interactables[0]?.transform.GetComponent<ClothingID>();
        if (id != null)
        {
            _enteredCode[1] = id.GetClothingID();
            if (CheckCode())
                _onCheck.Invoke();
            Debug.Log("Socket 1 entered");
        }
    }

    public void EnterSocket2()
    {
        var interactables = _interactors[2].interactablesSelected;
        ClothingID id = interactables[0]?.transform.GetComponent<ClothingID>();
        if (id != null)
        {
            _enteredCode[2] = id.GetClothingID();
            if (CheckCode())
                _onCheck.Invoke();
            Debug.Log("Socket2 Entered");
        }
    }


    private bool CheckCode()
    {
        if (_enteredCode.Length == _lockCode.Length)
        {
            for (int i = 0; i < _enteredCode.Length; i++)
            {
                if (_enteredCode[i] != _lockCode[i])
                    return false;
            }
            Debug.Log("Is returning true");
            return true;
        }
        else return false;
    }
}
