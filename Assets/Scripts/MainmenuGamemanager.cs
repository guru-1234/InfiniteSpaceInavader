using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainmenuGamemanager : MonoBehaviour
{
   public void NewGame()
   {
       SceneManager.LoadScene(1);
    }
   public void ExitMainMenu()
   {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
