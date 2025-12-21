using UnityEngine;

public class HealthBonus : MonoBehaviour
{
    public float healthBoost = 1;

    private GameObject player;
    [SerializeField] private ObstacleHit playerInstance;

    void Start() {
        player = GameObject.FindWithTag("Player");
        playerInstance = player.GetComponent<ObstacleHit>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            playerInstance.health = Mathf.Min(playerInstance.health + healthBoost, playerInstance.maxHealth);
            Destroy(gameObject);
        }
    }
}
