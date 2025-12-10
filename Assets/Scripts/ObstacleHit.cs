using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleHit : MonoBehaviour
{
    public float maxHealth = 5f;
    public float health;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        health = Mathf.Min(health, maxHealth);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Obstacle")) {
            health -= other.GetComponent<ObstacleDamage>().damage;
            health = Mathf.Max(health, 0f);

            if (health <= 0f + 0.001f) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            Destroy(other.gameObject);
        }
    }
}
