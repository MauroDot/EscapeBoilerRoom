using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;

public class ExitDoorScript : MonoBehaviour
{
    [SerializeField]
    private bool _topLockActive;
    [SerializeField]
    private bool _bottomLockActive;

    [SerializeField]
    private GameObject _chain;

    [SerializeField]
    private Animator _anim;

    [SerializeField]
    private GameObject _topKey;
    [SerializeField]
    private GameObject _bottomKey;

    [SerializeField]
    private GameObject _gameOverScreen;

    [SerializeField]
    private GameObject _leftController;
    [SerializeField]
    private GameObject _rightController;

    //[SerializeField]
    //public AudioSource _doorCreak;
    //[SerializeField]
    //public AudioSource _completeSFX;

    [SerializeField]
    private GameObject _congratsText;

    //[SerializeField]
    //private ActionBasedContinuousMoveProvider _XROrigin;

    [SerializeField]
    UnityEvent _onCheck;
    void Start()
    {
        _topLockActive = true;
        _bottomLockActive = true;

        _anim = GetComponent<Animator>();
        //_XROrigin = GetComponent<ActionBasedContinuousMoveProvider>();
    }

    
    public void Update()
    {
        if (_topLockActive == false && _bottomLockActive == false)
        {
            _chain.SetActive(false);
            _topKey.SetActive(false);
            _bottomKey.SetActive(false);

            _anim.SetTrigger("OpenDoor");

            _gameOverScreen.SetActive(true);

            //_leftController.SetActive(false);

            //_doorCreak.Play();
            //_completeSFX.Play();

            _congratsText.SetActive(true);
            _onCheck.Invoke();
        }
    }

    public void TopLock()
    {
        _topLockActive = false;
    }

    public void BottomLock()
    {
        _bottomLockActive = false;
    }

    
}
