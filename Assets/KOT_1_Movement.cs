﻿using UnityEngine;

public class KOT_1_Movement : MonoBehaviour
{
    [SerializeField]
    public float MoveValue = 0.07f;
    public GameObject ptak;

    public GameObject Bomb;

    private float nextBombTimeSpan = 0.5f;

    private float nextBombTime;

    private float dicemntPooTimeStep = 3F;

    private float dicemntPooTime;
    private int pooConter;

    private int maxPoo = 5;

    // Use this for initialization
    void Start()
    {
        this.ptak = gameObject;
        this.nextBombTime = 0;

        this.dicemntPooTime = 0;
        this.pooConter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > this.dicemntPooTime)
        {
            this.dicemntPooTime = Time.time + this.dicemntPooTimeStep;
            this.pooConter = this.pooConter > 0 ? this.pooConter - 1 : 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x + MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_right");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x - MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_left");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y - MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_down");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y + MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_up");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > this.nextBombTime && this.pooConter < this.maxPoo)
            {
                this.pooConter = this.pooConter + 1;
                this.nextBombTime = Time.time + this.nextBombTimeSpan;
                Instantiate(this.Bomb, transform.position, Quaternion.identity);
                GetComponent<AudioSource>().Play();
            }
        }
    }
}

