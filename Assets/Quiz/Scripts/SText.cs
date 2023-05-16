using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SText : MonoBehaviour
{
    public List<Text> textSize;
    private static string key = "0num";

    [SerializeField] private Slider slider;
    [SerializeField] private Text textComp;

    // Start is called before the first frame update
    private void Start()
    {
        if (PlayerPrefs.HasKey(key))
        {
            LoadSize();
        }
        else
        {
            UpdateText(slider.value);
            slider.onValueChanged.AddListener(UpdateText);
        }

    }

    // Update is called once per frame
    void UpdateText(float val)  
    {
        float slr = slider.value; 
        textComp.text = slr.ToString("0");

        for (int s = 0; s < textSize.Count; s++)
        {
            PlayerPrefs.SetInt(key, textSize[s].fontSize = (int)slr);
        }
    }

    private void LoadSize()
    {
        slider.value = PlayerPrefs.GetInt(key);

        UpdateText(slider.value);
        slider.onValueChanged.AddListener(UpdateText);
    }
}
