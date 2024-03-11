using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class LeversTrigger : MonoBehaviour
{
    [SerializeField]
    private bool _leverOneActive;
    [SerializeField]
    private bool _leverTwoActive;

    [SerializeField]
    private AudioSource _keySpawnAudio;

    //[SerializeField]
    //int[] _lockCode = new int[2] { 1, 2 };
    //int[] _enteredCode = { 0, 0 };
    //private XRSimpleInteractable[] _interactors;
    //[SerializeField] UnityEvent _onCheck;

    [SerializeField]
    private GameObject _key;

    private void Start()
    {
        _leverOneActive = false;
        _leverTwoActive = false;
    }

    public void Update()
    {
        if (_leverOneActive == true && _leverTwoActive == true)
        {
            //_onCheck.Invoke();
            //_keySpawnAudio.Play();
            _key.SetActive(true);
        }
    }

    public void LeverToggleOne()
    {
        _leverOneActive = true;
    }

    public void LeverToggleTwo()
    {
        _leverTwoActive = true;
    }

    public void LeverToggleOneFalse()
    {
        _leverOneActive = false;
    }

    public void LeverToggleTwoFalse()
    {
        _leverTwoActive = false;
    }

    //public void CheckBools()
    //{
    //    //Triggers the Action
    //    //Gets called on by the XR Simple Interactor Event

    //    // Levers();

    //    if (_leverOneActive == true && _leverTwoActive == true)
    //    {
    //        //_onCheck.Invoke();
    //        _key.SetActive(true);
    //    }
    //}

    //public void Levers(int levers)
    //{
    //    //Levers 1 & 2

    //    //For each loop??

    //    //Sets Bools to active
    //}


    /// <summary>
    /// //////////OR Multiple Methods
    /// </summary>

    //////public void LeverOne()
    //////{
    //////    var interactables = _interactors[1];
    //////    LeverID id = interactables?.transform.GetComponent<LeverID>();
    //////    if (id != null)
    //////    {
    //////        _enteredCode[0] = id.GetLeverID();
    //////        if (CheckID())
    //////            _onCheck.Invoke();
    //////    }
    //////}

    //////public void LeverTwo()
    //////{
    //////    var interactables = _interactors[2];
    //////    LeverID id = interactables?.transform.GetComponent<LeverID>();
    //////    if (id != null)
    //////    {
    //////        _enteredCode[0] = id.GetLeverID();
    //////        if (CheckID())
    //////            _onCheck.Invoke();
    //////    }
    //////}

    //////private bool CheckID()
    //////{
    //////    if (_enteredCode.Length = _lockCode.Length)
    //////    {
    //////        for (int i = 0; i < _enteredCode.Length; i++)
    //////        {
    //////            if (_enteredCode[i] != _lockCode[i])
    //////                return false;
    //////        }
    //////        return true;
    //////    }
    //////    else return false;
    //////}
}
