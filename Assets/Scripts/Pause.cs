using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool isPause;

    private Canvas pauseCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseCanvas = GetComponent<Canvas>();
        pauseCanvas.enabled = false;
        isPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Toggle();
        }
    }

    public void Toggle() {
        pauseCanvas.enabled = !pauseCanvas.enabled;
        isPause = !isPause;
    }
}
