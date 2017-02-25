using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public Text WinText;
	// Use this for initialization
	void Start ()
	{
	    this.WinText.text = string.Empty;
	}
	
	// Update is called once per frame
	void Update () {
	    if (GameObject.FindGameObjectsWithTag("Player").Count()<2)
	    {
            this.WinText.text = "Game Over";
	        foreach (var gameObj in GameObject.FindGameObjectsWithTag("Player"))
	        {
                gameObj.SetActive(false);
	        }

            foreach (var gameObj in GameObject.FindGameObjectsWithTag("Brick"))
            {
                gameObj.SetActive(false);
            }
        }
	}
}
