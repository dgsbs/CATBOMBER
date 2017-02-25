using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeGame : MonoBehaviour {
    public GameObject Cat1;
    public GameObject Cat2;
    public GameObject Brick;
    public GameObject MainBackground;
    public GameObject DestroyableBrick;

    // Use this for initialization
    void Start()
    {
        Vector3 brickSize = Brick.GetComponent<Renderer>().bounds.size;
        Vector2 startPos = new Vector2(Brick.transform.position.x, Brick.transform.position.y);
        Vector2 screenSize = GetScreenSize();
        int numberOfColumns = 21; // (int)(screenSize.x / brickSize.x);
        int numberOfRows = 17; // (int)(screenSize.y / brickSize.y);

        //AddEdgeColider(startPos, brickSize, numberOfColumns, numberOfRows);
        SetPlayers(startPos, brickSize, numberOfColumns, numberOfRows);

        for (int i = 0; i < numberOfColumns; i++)
        {
            for (int j = 0; j < numberOfRows; j++)
            {
                if (i == 0 || i == numberOfColumns - 1 || j == 0 || j == numberOfRows - 1)
                {
                    AddBrick(startPos, new Vector2(i * brickSize.x, j * brickSize.y));
                }
                else if ((i % 2 == 0) && (j % 2 == 0))
                {
                    AddColideBlock(startPos, new Vector2(i * brickSize.x, j * brickSize.y));
                }
                else
                {
                    float rndNumber = Random.Range(0, numberOfColumns * numberOfRows);
                    if (rndNumber % 6 == 0)
                    {
                        AddDestroyableBrick(startPos, new Vector2(i * brickSize.x, j * brickSize.y));
                    }
                }
            }
        }
    }

    void SetPlayers(Vector3 startPos, Vector3 brickSize, int numberOfColumns, int numberOfRows)
    {
        Cat1.transform.position = new Vector3(startPos.x + brickSize.x, startPos.y - brickSize.y, Cat1.transform.position.z);
        Cat2.transform.position = new Vector3(startPos.x + (brickSize.x * numberOfColumns - 2), startPos.y - (brickSize.y * (numberOfRows - 2)), Cat2.transform.position.z);
    }

    //void AddEdgeColider(Vector2 startPos, Vector2 size, int numberOfColumns, int numberOfRows)
    //{
    //    var edgeColider = MainBackground.AddComponent<EdgeCollider2D>();

    //    List<Vector2> points = new List<Vector2>();
    //    points.Add(new Vector2(startPos.x + size.x / 2, startPos.y + size.y*1.5f));
    //    points.Add(new Vector2(startPos.x + (numberOfColumns * size.x) - (size.x / 2), startPos.y + size.y * 1.5f));
    //    //points.Add(new Vector2(startPos.x + (size.x * numberOfColumns - 2), startPos.y - size.y));
    //    //points.Add(new Vector2(startPos.x + (size.x * numberOfColumns - 2), startPos.y - (size.y * (numberOfRows - 2))));
    //    //points.Add(new Vector2(startPos.x + size.x, startPos.y - (size.y * (numberOfRows - 2))));
    //    //points.Add(new Vector2(startPos.x + size.x, startPos.y - size.y));
    //    edgeColider.points = points.ToArray();
    //}

    void AddBrick(Vector3 startPos, Vector2 size)
    {
        Vector3 newPosition = new Vector3(startPos.x + size.x, startPos.y - size.y);
        Instantiate(Brick, newPosition, Brick.transform.rotation);
    }

    void AddColideBlock(Vector3 startPos, Vector2 size)
    {
        Vector3 newPosition = new Vector3(startPos.x + size.x, startPos.y - size.y);
        GameObject newBrick = Instantiate(Brick, newPosition, Brick.transform.rotation);
        newBrick.AddComponent<BoxCollider2D>();
    }

    void AddDestroyableBrick(Vector3 startPos, Vector2 size)
    {
        Vector3 newPosition = new Vector3(startPos.x + size.x, startPos.y - size.y);
        GameObject newBrick = Instantiate(DestroyableBrick, newPosition, DestroyableBrick.transform.rotation);
    }

    Vector2 GetScreenSize()
    {
        Camera cam = Camera.main;
        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        return new Vector2(width, height);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
