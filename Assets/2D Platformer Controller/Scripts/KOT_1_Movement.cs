using UnityEngine;

public class KOT_1_Movement : MonoBehaviour
{
    private const float MoveValue = 0.07f;
    public GameObject ptak;

    public GameObject Bomb;

    private float nextBombTimeSpan = 0.5f;

    private float nextBombTime;

    // Use this for initialization
    void Start()
    {
        this.ptak = gameObject;
        this.nextBombTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x + KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_right");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x - KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_left");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y - KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_down");
        }
        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y + KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_white_up");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > this.nextBombTime)
            {
                this.nextBombTime = Time.time + this.nextBombTimeSpan;
                Instantiate(this.Bomb, transform.position, Quaternion.identity);
            }
        }
    }
}

