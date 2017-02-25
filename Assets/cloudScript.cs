using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudScript : MonoBehaviour {
    private float blow0 = 1.5F;

    private float blow1 = 2F;

    private float blow2 = 2.5F;

    private float hide = 3;

    private float startTime;

    // Use this for initialization
    void Start()
    {
        this.startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > this.startTime + this.blow0)
        {
            this.transform.localScale += new Vector3(0.001F, 0.001F);
        }

        if (Time.time > this.startTime + this.blow1)
        {
            this.transform.localScale += new Vector3(0.002F, 0.002F);
        }

        if (Time.time > this.startTime + this.blow2)
        {
            this.transform.localScale += new Vector3(0.008F, 0.008F);
        }

        if (Time.time > this.startTime + this.hide)
        {
            this.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("Brick"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
