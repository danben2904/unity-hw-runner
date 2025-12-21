using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordMainMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        const string key = "RecordScore";
        if (!PlayerPrefs.HasKey(key)) {
            PlayerPrefs.SetFloat(key, 0f);
            PlayerPrefs.Save();
        }
        gameObject.GetComponent<TMPro.TMP_Text>().text = "Рекорд : " + PlayerPrefs.GetFloat(key);
    }
}
