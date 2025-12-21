using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;
    public float accelerationCoef = 0.05f;
    private float boundary = 2;

    public float jumpDist = 2.5f;
    private float jumpBoundary = 1.5f;
    private bool upJump = true;

    public float points = 0f;

    private GameObject pause;
    [SerializeField] private Pause pauseInstance;
    private float previousSpeed;

    void Start()
    {
        transform.position = new Vector3(0f, jumpBoundary, 0f);
        pause = GameObject.FindWithTag("Pause");
        pauseInstance = pause.GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speed != 0f) {
            previousSpeed = speed;
        }

        if (pauseInstance.isPause) {
            speed = 0;
        } else {
            speed = previousSpeed;
        }

        if (!pauseInstance.isPause) {
            float x = Input.GetAxis("Horizontal");

            Vector3 movement = new Vector3(x, 0f, 0f);

            transform.Translate(movement * speed * 2f * Time.deltaTime);

            if (transform.position.x > boundary) {
                transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
            }

            if (transform.position.x < -boundary) {
                transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
            }

            // jump

            Vector3 movementJump = new Vector3(0f, speed, 0f);

            if (Input.GetKeyDown(KeyCode.Space) && isOnGround()) {
                transform.Translate(movementJump * Time.deltaTime);
                upJump = true;
            }

            if (isOnGround()) {
                transform.position = new Vector3(transform.position.x, jumpBoundary, transform.position.z);
            }
            if (!isOnGround()) {
                if (transform.position.y < jumpBoundary + jumpDist && upJump) {
                    transform.Translate(movementJump * Time.deltaTime);
                } else {
                    upJump = false;
                    transform.Translate(-1f * movementJump * Time.deltaTime);
                }
            }
            speed += accelerationCoef * Time.deltaTime;
            points += Time.deltaTime;
        }
    }

    bool isOnGround() {
        return transform.position.y <= jumpBoundary;
    }
}
