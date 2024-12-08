using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float flyPower = 0.5f;
    [SerializeField] ParticleSystem fireParticles1;
    [SerializeField] ParticleSystem fireParticles2;
    Rigidbody2D rb2d;
    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            RotatePlayer();
            Fly();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount * Time.deltaTime);
        }
    }

    private void Fly()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.AddForce(transform.up * flyPower * Time.deltaTime, ForceMode2D.Impulse);

            if (!fireParticles1.isPlaying && !fireParticles2.isPlaying)
            {
                fireParticles1.Play();
                fireParticles2.Play();
            }
        }
        else
        {
            if (fireParticles1.isPlaying && fireParticles2.isPlaying)
            {
                fireParticles1.Stop();
                fireParticles2.Stop();
            }
        }
    }
}
