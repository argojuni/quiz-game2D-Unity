using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opstion : MonoBehaviour
{
    public static bool GameIsPaused = false;
    [SerializeField] private GameObject Options;
    //[SerializeField] private GameObject VideoIntro;
    [SerializeField] private GameObject AudioMusic;
    private void Start()
    {
        Options.SetActive(false);
        //VideoIntro.SetActive(true);
        //AudioMusic.SetActive(false);
        //StartCoroutine(videoSkip());
    }
    public void OpstionBtn()
    {
        Options.SetActive(true);
    }

    public void CloseBtn()
    {
        Options.SetActive(false);
    }

    public void buttonPause()
    {
        AudioManager.Instance.PlaySFX("Click");

        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        AudioManager.Instance.PlaySFX("Click");
        Options.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        AudioManager.Instance.PlaySFX("Click");
        Options.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    //IEnumerator videoSkip()
    //{
    //    yield return new WaitForSeconds(5);
    //    //VideoIntro.SetActive(false);
    //    AudioMusic.SetActive(true);
    //}
}
