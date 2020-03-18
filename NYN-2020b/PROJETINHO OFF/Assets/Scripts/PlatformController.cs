using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlatformController : MonoBehaviour
{
    [Header ("Color States")]
    public bool greenState = false;
    public bool blueState = false;
    public bool redState = false;
    public bool cyanState = false;
    public bool magentaState = false;
    public bool yellowState = false;
    public bool whiteState = false;

    [Header("Game Objects")]
    public GameObject blue;
    public GameObject red;
    public GameObject green;
	public GameObject cyan;
	public GameObject magenta;
	public GameObject yellow;
	public GameObject white;

    [Header("GameObj Layers")]
    public GameObject character;
    private GameObject[] moveLayerGreen;
    private GameObject[] moveLayerBlue;
    private GameObject[] moveLayerRed;
	private GameObject[] moveLayerCyan;
	private GameObject[] moveLayerMagenta;
	private GameObject[] moveLayerYellow;
	private GameObject[] moveLayerWhite;

    [Header ("Is Colliding")]
    public bool isCollidingGreen = false;
    public bool isCollidingBlue = false;
    public bool isCollidingRed = false;
	public bool isCollidingCyan = false;
	public bool isCollidingMagenta = false;
	public bool isCollidingYellow = false;
	public bool isCollidingWhite = false;

    // Use this for initialization

    void Start()
    {

        //10 = Invisible Platform Green
        //11 - Invisible Platform Blue
        //12 - Invisible Platform Red

        moveLayerGreen = GameObject.FindGameObjectsWithTag("Green");
        moveLayerBlue = GameObject.FindGameObjectsWithTag("Blue");
        moveLayerRed = GameObject.FindGameObjectsWithTag("Red");
        moveLayerCyan = GameObject.FindGameObjectsWithTag("Cyan");
        moveLayerMagenta = GameObject.FindGameObjectsWithTag("Magenta");
        moveLayerYellow = GameObject.FindGameObjectsWithTag("Yellow");
        moveLayerWhite = GameObject.FindGameObjectsWithTag("White");
		/*
        moveLayerRed.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
        moveLayerGreen.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
        moveLayerBlue.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
        moveLayerCyan.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
        moveLayerMagenta.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
        moveLayerYellow.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
        moveLayerWhite.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
		*/

		ColorStart();
    }

    void Update()
    {

		moveLayerGreen = GameObject.FindGameObjectsWithTag("Green");
		moveLayerBlue = GameObject.FindGameObjectsWithTag("Blue");
		moveLayerRed = GameObject.FindGameObjectsWithTag("Red");
		moveLayerCyan = GameObject.FindGameObjectsWithTag("Cyan");
		moveLayerMagenta = GameObject.FindGameObjectsWithTag("Magenta");
		moveLayerYellow = GameObject.FindGameObjectsWithTag("Yellow");
		moveLayerWhite = GameObject.FindGameObjectsWithTag("White");

		if (Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.G) || Input.GetKeyDown(KeyCode.Keypad2) || Input.GetButtonDown("GreenButton"))
        {
            if (greenState == true)
            {

                greenState = false;
                green.layer = 10;
                //moveLayerGreen.layer = 10;
                //moveLayerGreen.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
				ColorUpdate("green", .18f, 10);
            }
            else
            {
				if (isCollidingGreen == false)
                {
					if (!((isCollidingCyan == true && blueState == true) || (isCollidingYellow == true && redState == true) || (isCollidingWhite == true && magentaState == true)))
					{
						greenState = true;
						green.SetActive (true);
						green.layer = 8;
						//moveLayerGreen.layer = 8;
						//moveLayerGreen.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
						ColorUpdate("green", 1f, 8);
					}
                }

            }
        }

        if (Input.GetKeyDown(KeyCode.L) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetButtonDown("BlueButton"))
        {
            if (blueState == true)
            {

                blueState = false;
                blue.layer = 11;
                //moveLayerBlue.layer = 11;
                //moveLayerBlue.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
				ColorUpdate("blue", .18f, 11);
			}

            else
            {
				if (isCollidingBlue == false)
				{
					if (!((isCollidingCyan == true && greenState == true) || (isCollidingMagenta == true && redState == true) || (isCollidingWhite == true && yellowState == true))) {
						//|| (isCollidingCyan == false && greenState == true) || (isCollidingMagenta == false && redState == true)
						blueState = true;
						blue.SetActive (true);
						blue.layer = 8;
						//moveLayerBlue.layer = 8;
						//moveLayerBlue.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
						ColorUpdate("blue", 1f, 8);
					}
                }

            }
        }
		if (Input.GetKeyDown (KeyCode.J) || Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.Keypad1) || Input.GetButtonDown("RedButton")) {
			if (redState == true) {

				redState = false;
				red.layer = 12;
				//moveLayerRed.layer = 12;
				//moveLayerRed.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
				ColorUpdate("red", .18f, 12);
			} 
			else
			{
				if (isCollidingRed == false)
				{
					if (!((isCollidingYellow == true && greenState == true) || (isCollidingMagenta == true && blueState == true) || (isCollidingWhite == true && cyanState == true))) {
						//|| (isCollidingMagenta == false && blueState == true) || (isCollidingYellow == false && greenState == true)
						redState = true;
						red.SetActive (true);
						red.layer = 8;
						//moveLayerRed.layer = 8;
						//moveLayerRed.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
						ColorUpdate("red", 1f, 8);
					}
				}
			}
		}


			//Cores CMY +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
			if (blueState == true && greenState == true)
			{
				
				cyanState = true;
				cyan.SetActive(true);
				cyan.layer = 8;
				//moveLayerCyan.layer = 8;
				//moveLayerCyan.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
				ColorUpdate("cyan", 1f, 8);
		}

			else
			{
				cyanState = false;
				cyan.layer = 13;
				//moveLayerCyan.layer = 13;
				//moveLayerCyan.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
				ColorUpdate("cyan", .08f, 13);
		}




			if (redState == true && blueState == true) {
				magentaState = true;
				magenta.SetActive (true);
				magenta.layer = 8;
				//moveLayerMagenta.layer = 8;
				//moveLayerMagenta.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
				ColorUpdate("magenta", 1f, 8);
		} 

			else {
				magentaState = false;
				magenta.layer = 14;
				//moveLayerMagenta.layer = 14;
				//moveLayerMagenta.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
				ColorUpdate("magenta", .08f, 14);
		}


			if (greenState == true && redState == true) {

				yellowState = true;
				yellow.SetActive (true);
				yellow.layer = 8;
				//moveLayerYellow.layer = 8;
				//moveLayerYellow.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
				ColorUpdate("yellow", 1f, 8);
		} 

			else {
				yellowState = false;
				yellow.layer = 15;
				//moveLayerYellow.layer = 15;
				//moveLayerYellow.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
				ColorUpdate("yellow", .08f, 15);
		}

			if (greenState == true && blueState == true && redState == true) {
				whiteState = true;
				white.SetActive (true);
				white.layer = 8;
				//moveLayerWhite.layer = 8;
				//moveLayerWhite.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, 1f);
				ColorUpdate("white", 1f, 8);
		} 

			else {
				whiteState = false;
				white.layer = 16;
				//moveLayerWhite.layer = 16;
				//moveLayerWhite.GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
				ColorUpdate("white", .08f, 16);
		}
    }

	public void ColorStart()
	{
        #region Iniciando Cores
        for (int i = 0; i < moveLayerRed.Length; i++)
		{
			moveLayerRed[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
		}

		for (int i = 0; i < moveLayerGreen.Length; i++)
		{
			moveLayerGreen[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
		}

		for (int i = 0; i < moveLayerBlue.Length; i++)
		{
			moveLayerBlue[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .18f);
		}

		for (int i = 0; i < moveLayerCyan.Length; i++)
		{
			moveLayerCyan[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
		}

		for (int i = 0; i < moveLayerMagenta.Length; i++)
		{
			moveLayerMagenta[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
		}

		for (int i = 0; i < moveLayerYellow.Length; i++)
		{
			moveLayerYellow[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
		}

		for (int i = 0; i < moveLayerWhite.Length; i++)
		{
			moveLayerWhite[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, .08f);
		}
        #endregion
    }

    public void ColorUpdate(string color, float colorValue, int layerNumber)
	{
        #region Atualizando cores
        if (color == "red")
		{
			for (int i = 0; i < moveLayerRed.Length; i++)
			{
				moveLayerRed[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerRed[i].layer = layerNumber;
			}
		}

		else if(color == "green")
		{
			for (int i = 0; i < moveLayerGreen.Length; i++)
			{
				moveLayerGreen[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerGreen[i].layer = layerNumber;
			}
		}

		else if(color == "blue")
		{
			for (int i = 0; i < moveLayerBlue.Length; i++)
			{
				moveLayerBlue[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerBlue[i].layer = layerNumber;
			}
		}

		else if(color == "cyan")
		{
			for (int i = 0; i < moveLayerCyan.Length; i++)
			{
				moveLayerCyan[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerCyan[i].layer = layerNumber;
			}
		}

		else if(color == "magenta")
		{
			for (int i = 0; i < moveLayerMagenta.Length; i++)
			{
				moveLayerMagenta[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerMagenta[i].layer = layerNumber;
			}
		}

		else if(color == "yellow")
		{
			for (int i = 0; i < moveLayerYellow.Length; i++)
			{
				moveLayerYellow[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerYellow[i].layer = layerNumber;
			}
		}

		else
		{
			for (int i = 0; i < moveLayerWhite.Length; i++)
			{
				moveLayerWhite[i].GetComponent<Renderer>().material.color = new Color(1f, 1f, 1f, colorValue);
				moveLayerWhite[i].layer = layerNumber;
			}
		}
        #endregion
    }

}
