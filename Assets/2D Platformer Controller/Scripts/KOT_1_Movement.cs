using UnityEngine;

public class KOT_1_Movement : MonoBehaviour
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
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x + KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.x = newPosition.x - KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y - KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 newPosition = this.ptak.transform.position;
            newPosition.y = newPosition.y + KOT_1_Movement.MoveValue;
            this.ptak.transform.position = newPosition;
        }
    }
}

