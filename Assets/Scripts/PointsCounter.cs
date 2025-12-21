using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCounter : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private Player playerInstance;

    void Start() {
        player = GameObject.FindWithTag("Player");
        playerInstance = player.GetComponent<Player>();
    }

    void Update()
    {
        gameObject.GetComponent<TMPro.TMP_Text>().text = "Очки : " + playerInstance.points;
    }
}
