using UnityEngine;

public class ShieldBonus : MonoBehaviour
{
    public float shieldDuration = 10f;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            PlayerShield shield = other.GetComponent<PlayerShield>();
            shield.ActivateShield(shieldDuration);

            Destroy(gameObject);
        }
    }
}
