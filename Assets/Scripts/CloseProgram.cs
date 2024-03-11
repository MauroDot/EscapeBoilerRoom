using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseProgram : MonoBehaviour
{
    public void CloseApplication()
    {
        Application.Quit();
    }
}
