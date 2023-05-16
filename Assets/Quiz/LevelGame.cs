using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelGame : MonoBehaviour
{
    public Button[] levellock;

    Scene scene;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("levelIsUnlocked"))
        {
            PlayerPrefs.SetInt("levelIsUnlocked", 1);
        }
        scene = SceneManager.GetActiveScene();

        if(scene.name == "MainMenu")
        {
            for (int i = 1; i < levellock.Length; i++)
            {
                levellock[i].interactable = false;
            }

            for (int i = 1; i<= PlayerPrefs.GetInt("levelUnlocked"); i++)
            {
                levellock[i].interactable = true;
            }
                       
        }
    }
}
