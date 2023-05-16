using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelUnlockHandler : MonoBehaviour
{
    [SerializeField] Button[] buttons;
    int unlockLevelNumber;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("levelIsUnlocked"))
        {
            PlayerPrefs.SetInt("levelIsUnlocked", 1);
        }

        unlockLevelNumber = PlayerPrefs.GetInt("levelIsUnlocked");
        Debug.Log(unlockLevelNumber);

        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
    }
    private void Update()
    {
        unlockLevelNumber = PlayerPrefs.GetInt("levelIsUnlocked");

        for (int i = 0; i < unlockLevelNumber; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.DeleteAll();
        Debug.Log("Reset Levle");
    }
}
