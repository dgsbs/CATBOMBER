using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pooScript : MonoBehaviour {
    public GameObject cloud;

    private float makeCloud = 3;
    private float hide = 3.5F;

    private float startTime;

    // Use this for initialization
    void Start()
    {
        this.startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > this.startTime + this.makeCloud)
        {
            Instantiate(cloud, transform.position, Quaternion.identity);
        }

        if (Time.time > this.startTime + this.hide)
        {
            this.gameObject.SetActive(false);
        }
    }
}
