using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManagement : MonoBehaviour
{
    public void SceneTransition()
    {
        SceneManager.LoadScene("Game");
    }
}
