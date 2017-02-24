﻿using UnityEngine;

public class KOT_2_Movement : MonoBehaviour
{
    private const float MoveValue = 0.07f;
    public GameObject ptak;

    // Use this for initialization
    void Start()
    {
        this.ptak = gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x + KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x - KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y - KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y + KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
    }
}

