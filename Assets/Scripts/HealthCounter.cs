using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCounter : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private ObstacleHit playerInstance;

    void Start() {
        player = GameObject.FindWithTag("Player");
        playerInstance = player.GetComponent<ObstacleHit>();
    }

    void Update()
    {
        gameObject.GetComponent<TMPro.TMP_Text>().text = "Текущее здоровье : " + playerInstance.health;
    }
}
