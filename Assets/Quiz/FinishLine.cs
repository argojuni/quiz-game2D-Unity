using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public int levelToUnlock;
    int numberOfUnlockedLevels;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")){
            numberOfUnlockedLevels = PlayerPrefs.GetInt("levelIsUnlocked");
            if (numberOfUnlockedLevels <= levelToUnlock)
            {
                PlayerPrefs.SetInt("levelIsUnlocked", numberOfUnlockedLevels+1);
            }
        }
    }
}
