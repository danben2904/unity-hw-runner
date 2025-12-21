using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour
{
    private GameObject pause;
    [SerializeField] private Pause pauseInstance;

    void Start()
    {
        pause = GameObject.FindWithTag("Pause");
        pauseInstance = pause.GetComponent<Pause>();
    }

    public void toMainMenu() {
        SceneManager.LoadScene(0);
    }

    public void Resume() {
        pauseInstance.Toggle();
    }
}
