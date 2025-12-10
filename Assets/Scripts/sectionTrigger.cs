using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sectionTrigger : MonoBehaviour
{
    public GameObject[] sections;

    private int sectionCount = 10;

    private bool is_empty = false;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Generate")) {
            if (is_empty) {
                int sectionID = 0;
                Instantiate(sections[sectionID], new Vector3(0f, 0f, 35f), Quaternion.identity);
                is_empty = false;
            } else {
                int sectionID = Random.Range(1, sectionCount);
                Instantiate(sections[sectionID], new Vector3(0f, 0f, 35f), Quaternion.identity);
                is_empty = true;
            }
        }
    }
}
