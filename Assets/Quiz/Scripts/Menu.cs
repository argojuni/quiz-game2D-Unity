using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject starLevel; 
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject setting;
    [SerializeField] private GameObject about;
    [SerializeField] private GameObject exit;

    public void Start()
    {
        menu.SetActive(true);
        setting.SetActive(false);
        starLevel.SetActive(false);
        about.SetActive(false);
        exit.SetActive(true);
    }

    public void StartMenu()
    {
        menu.SetActive(false);
        starLevel.SetActive(true);
        exit.SetActive(false);
        //start
    }

    public void Setting()
    {
        setting.SetActive(true);
        menu.SetActive(false);
        starLevel.SetActive(false);
        exit.SetActive(false);
    }

    public void About()
    {
        about.SetActive(true);
        exit.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void BackMenu()
    {
        menu.SetActive(true);
        exit.SetActive(true);
        setting.SetActive(false);
        starLevel.SetActive(false);
        about.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //start
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //PlayerPrefs.DeleteKey("");
    }
}
