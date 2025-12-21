using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
    public bool isShieldActive = false;

    private Coroutine shieldRoutine;

    public void ActivateShield(float duration) {
        if (shieldRoutine != null) {
            StopCoroutine(shieldRoutine);
        }

        shieldRoutine = StartCoroutine(ShieldRoutine(duration));
    }

    private IEnumerator ShieldRoutine(float duration) {
        isShieldActive = true;

        yield return new WaitForSeconds(duration);

        isShieldActive = false;
        shieldRoutine = null;
    }

    public void BreakShield() {
        isShieldActive = false;

        if (shieldRoutine != null) {
            StopCoroutine(shieldRoutine);
            shieldRoutine = null;
        }
    }
}
