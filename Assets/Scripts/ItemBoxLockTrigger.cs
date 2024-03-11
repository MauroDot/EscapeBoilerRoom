using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBoxLockTrigger : MonoBehaviour
{

    private bool _lockPinkActive;

    private bool _lockPurpleActive;

    [SerializeField]
    private GameObject _lockPink;

    [SerializeField]
    private GameObject _lockPurple;

    [SerializeField]
    private GameObject _itemBoxHandle;
    void Start()
    {
        _lockPinkActive = true;
        _lockPurpleActive = true;
    }

    public void Update()
    {
        if (_lockPinkActive == false && _lockPurpleActive == false)
        {
            _itemBoxHandle.SetActive(true);
        }
    }

    public void PinkLock()
    {
        _lockPinkActive = false;
    }

    public void PurpleLock()
    {
        _lockPurpleActive = false;
    }

}
