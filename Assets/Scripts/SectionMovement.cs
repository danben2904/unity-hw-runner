using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionMovement : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private Player playerInstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        player = GameObject.FindWithTag("Player");
        playerInstance = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update() {
        transform.position += new Vector3(0f, 0f, -playerInstance.speed) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Destroy")) {
            Destroy(gameObject);
        }
    }
}
