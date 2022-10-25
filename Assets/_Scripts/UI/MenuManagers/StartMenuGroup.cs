using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuGroup : MonoBehaviour
{
    public void PlayGame(string scene)
   {
        scene = "Assets/Scenes/Menus/Main/GameOverMenu.unity";
        SceneManager.LoadScene(scene);
        SoundManager.PlaySound();
   }

   public void QuitGame()
   {
      Application.Quit();
      Debug.Log("Game is exiting");
   }
}