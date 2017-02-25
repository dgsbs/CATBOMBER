using UnityEngine;

public class KOT_2_Movement : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x + KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_black_right");
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x - KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_black_left");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y - KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_black_down");
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y + KOT_2_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
            GetComponent<Animator>().Play("cat_black_up");
        }

        if (Input.GetKey(KeyCode.Keypad0))
        {
            if (Time.time > this.nextBombTime)
            {
                this.nextBombTime = Time.time + this.nextBombTimeSpan;
                Instantiate(this.Bomb, transform.position, Quaternion.identity);
            }
        }
    }
}

