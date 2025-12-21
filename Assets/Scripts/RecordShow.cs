using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordShow : MonoBehaviour
{
    void Update()
    {
        const string key = "RecordScore";
        gameObject.GetComponent<TMPro.TMP_Text>().text = "Рекорд : " + PlayerPrefs.GetFloat(key);
    }
}
