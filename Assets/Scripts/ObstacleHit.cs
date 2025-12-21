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
            PlayerShield shield = GetComponent<PlayerShield>();
            if (shield.isShieldActive) {
                shield.BreakShield();
            } else {
                health -= other.GetComponent<ObstacleDamage>().damage;
                health = Mathf.Max(health, 0f);

                if (health <= 0f + 0.001f) {
                    const string key = "RecordScore";
                    Player player = GetComponent<Player>();

                    if (player.points > PlayerPrefs.GetFloat(key)) {
                        PlayerPrefs.SetFloat(key, player.points);
                        PlayerPrefs.Save();

                        Debug.Log("New record value: " +  PlayerPrefs.GetFloat(key));
                    }

                    SceneManager.LoadScene(0);
                }
            }
            Destroy(other.gameObject);
        }
    }
}
