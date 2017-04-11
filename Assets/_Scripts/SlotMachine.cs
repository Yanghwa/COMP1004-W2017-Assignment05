using UnityEngine;
using System.Collections;

public class SlotMachine : MonoBehaviour {

    public float period = 0.0f;

    // Use this for initialization
    void Start () {
        resetAll();
	}

    // Update is called once per frame
    void Update()
    {
        _changeInfoText();
        
    }


    private int playerMoney = 1000;
	private int winnings = 0;
	private int jackpot = 5000;
	private float turn = 0.0f;
	private int playerBet = 0;
	private float winNumber = 0.0f;
	private float lossNumber = 0.0f;
	private string[] spinResult;
	private string fruits = "";
	private float winRatio = 0.0f;
	private float lossRatio = 0.0f;
	private int grapes = 0;
	private int bananas = 0;
	private int oranges = 0;
	private int cherries = 0;
	private int bars = 0;
	private int bells = 0;
	private int sevens = 0;
	private int blanks = 0;
    private string[] betLine = { " ", " ", " " };
    public AudioClip spinSound;
    public AudioClip winSound;
    public AudioClip loseSound;
    public Sprite grape;
    public Sprite banana;
    public Sprite orange;
    public Sprite cherry;
    public Sprite bar;
    public Sprite bell;
    public Sprite seven;
    public Sprite blank;


    /* Utility function to show Player Stats */
    private void showPlayerStats()
	{
		winRatio = winNumber / turn;
		lossRatio = lossNumber / turn;
		string stats = "";
		stats += ("Jackpot: " + jackpot + "\n");
		stats += ("Player Money: " + playerMoney + "\n");
		stats += ("Turn: " + turn + "\n");
		stats += ("Wins: " + winNumber + "\n");
		stats += ("Losses: " + lossNumber + "\n");
		stats += ("Win Ratio: " + (winRatio * 100) + "%\n");
		stats += ("Loss Ratio: " + (lossRatio * 100) + "%\n");
		Debug.Log(stats);
	}

	/* Utility function to reset all fruit tallies*/
	private void resetFruitTally()
	{
		grapes = 0;
		bananas = 0;
		oranges = 0;
		cherries = 0;
		bars = 0;
		bells = 0;
		sevens = 0;
		blanks = 0;
	}

	/* Utility function to reset the player stats */
	private void resetAll()
	{
		playerMoney = 1000;
		winnings = 0;
		jackpot = 5000;
		turn = 0;
		playerBet = 0;
		winNumber = 0;
		lossNumber = 0;
		winRatio = 0.0f;
	}

	/* Check to see if the player won the jackpot */
	private void checkJackPot()
	{
		/* compare two random values */
		var jackPotTry = Random.Range (1, 51);
		var jackPotWin = Random.Range (1, 51);
		if (jackPotTry == jackPotWin)
		{
			Debug.Log("You Won the $" + jackpot + " Jackpot!!");
			playerMoney += jackpot;
			jackpot = 1000;
		}
        GameObject.Find("infoText").GetComponent<UnityEngine.UI.Text>().text = "Jackpot!!";
    }

	/* Utility function to show a win message and increase player money */
	private void showWinMessage()
	{
		playerMoney += winnings;
		Debug.Log("You Won: $" + winnings);
		resetFruitTally();
		checkJackPot();
        AudioSource.PlayClipAtPoint(winSound, transform.position);
    }

	/* Utility function to show a loss message and reduce player money */
	private void showLossMessage()
	{
		playerMoney -= playerBet;
		Debug.Log("You Lost!");
		resetFruitTally();
        //Sound add
        //AudioSource.PlayClipAtPoint(loseSound, transform.position);
    }

    /* Utility function to check if a value falls within a range of bounds */
    private bool checkRange(int value, int lowerBounds, int upperBounds)
	{
		return (value >= lowerBounds && value <= upperBounds) ? true : false;

	}

	/* When this function is called it determines the betLine results.
    e.g. Bar - Orange - Banana */
	private string[] Reels()
	{
		
		int[] outCome = { 0, 0, 0 };

		for (var spin = 0; spin < 3; spin++)
		{
			outCome[spin] = Random.Range(1,65);

			if (checkRange(outCome[spin], 1, 27)) {  // 41.5% probability
				betLine[spin] = "blank";
				blanks++;
			}
			else if (checkRange(outCome[spin], 28, 37)){ // 15.4% probability
				betLine[spin] = "Grapes";
				grapes++;
			}
			else if (checkRange(outCome[spin], 38, 46)){ // 13.8% probability
				betLine[spin] = "Banana";
				bananas++;
			}
			else if (checkRange(outCome[spin], 47, 54)){ // 12.3% probability
				betLine[spin] = "Orange";
				oranges++;
			}
			else if (checkRange(outCome[spin], 55, 59)){ //  7.7% probability
				betLine[spin] = "Cherry";
				cherries++;
			}
			else if (checkRange(outCome[spin], 60, 62)){ //  4.6% probability
				betLine[spin] = "Bar";
				bars++;
			}
			else if (checkRange(outCome[spin], 63, 64)){ //  3.1% probability
				betLine[spin] = "Bell";
				bells++;
			}
			else if (checkRange(outCome[spin], 65, 65)){ //  1.5% probability
				betLine[spin] = "Seven";
				sevens++;
			}

		}
		return betLine;
	}

	/* This function calculates the player's winnings, if any */
	private void determineWinnings()
	{
		if (blanks == 0)
		{
			if (grapes == 3)
			{
				winnings = playerBet * 10;
			}
			else if (bananas == 3)
			{
				winnings = playerBet * 20;
			}
			else if (oranges == 3)
			{
				winnings = playerBet * 30;
			}
			else if (cherries == 3)
			{
				winnings = playerBet * 40;
			}
			else if (bars == 3)
			{
				winnings = playerBet * 50;
			}
			else if (bells == 3)
			{
				winnings = playerBet * 75;
			}
			else if (sevens == 3)
			{
				winnings = playerBet * 100;
			}
			else if (grapes == 2)
			{
				winnings = playerBet * 2;
			}
			else if (bananas == 2)
			{
				winnings = playerBet * 2;
			}
			else if (oranges == 2)
			{
				winnings = playerBet * 3;
			}
			else if (cherries == 2)
			{
				winnings = playerBet * 4;
			}
			else if (bars == 2)
			{
				winnings = playerBet * 5;
			}
			else if (bells == 2)
			{
				winnings = playerBet * 10;
			}
			else if (sevens == 2)
			{
				winnings = playerBet * 20;
			}
			else if (sevens == 1)
			{
				winnings = playerBet * 5;
			}
			else
			{
				winnings = playerBet * 1;
			}
			winNumber++;
			showWinMessage();
		}
		else
		{
            winnings = 0;
			lossNumber++;
			showLossMessage();
		}

	}

	public void OnSpinButtonClick()
	{
		//playerBet = 10; // default bet amount

		if (playerMoney == 0)
		{
			/*
			if (Debug.Log("You ran out of Money! \nDo you want to play again?","Out of Money!",MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				resetAll();
				showPlayerStats();
			}
			*/
		}
		else if (playerBet > playerMoney)
		{
			Debug.Log("You don't have enough Money to place that bet.");
		}
		else if (playerBet <= 0)
		{
			Debug.Log("All bets must be a positive $ amount.");
		}
		else if (playerBet <= playerMoney)
		{
			spinResult = Reels();
			fruits = spinResult[0] + " - " + spinResult[1] + " - " + spinResult[2];
			Debug.Log(fruits);
			determineWinnings();
			turn++;
			showPlayerStats();
            _betLineCheckerFirst();
            _betLineCheckerSecond();
            _betLineCheckerThird();
            //spinSound = Resources.Load<AudioClip>("Textures/Sound - Slot Stop Button - AudioJungle Download");
            playSpinSound();
		}
		else
		{
			Debug.Log("Please enter a valid bet amount");
		}
        playerBet = 0;
        showAllMoney();
        _checkPlayerMoney();
        //add sound
    }
    public void resetStat()
    {
        this.resetAll();
        _checkPlayerMoney();
        showAllMoney();
        GameObject.Find("Spin").GetComponent<UnityEngine.UI.Button>().interactable = true;
        GameObject.Find("1stSymbol").GetComponent<UnityEngine.SpriteRenderer>().sprite = seven;
        GameObject.Find("2ndSymbol").GetComponent<UnityEngine.SpriteRenderer>().sprite = seven;
        GameObject.Find("3thSymbol").GetComponent<UnityEngine.SpriteRenderer>().sprite = seven;
    }

    public void closeButton()
    {
        Debug.Log("Close the application");
        Application.Quit();
    }
    /// <summary>
    /// This method changes infoText to hook users
    /// </summary>
    private void _changeInfoText()
    {
        if (period > 4)
        {
            GameObject.Find("infoText").GetComponent<UnityEngine.UI.Text>().text = "Challenge Now!";
            //Debug.Log("1st try");
            period = 0;
        }
        if (period > 2)
        {
            GameObject.Find("infoText").GetComponent<UnityEngine.UI.Text>().text = "Chance to Win!";
            //Debug.Log("2nd try");
        }
        period += UnityEngine.Time.deltaTime;
    }

    private void showAllMoney()
    {
        GameObject.Find("betText").GetComponent<UnityEngine.UI.Text>().text = playerBet.ToString();
        GameObject.Find("totalCreditsText").GetComponent<UnityEngine.UI.Text>().text = playerMoney.ToString();
        GameObject.Find("winnerPaidText").GetComponent<UnityEngine.UI.Text>().text = winnings.ToString();
    }

    private void _checkPlayerMoney()
    {
        if(playerMoney < 500 || playerMoney-playerBet < 500)
        {
            GameObject.Find("bet500").GetComponent<UnityEngine.UI.Button>().interactable = false;
        } else
        {
            GameObject.Find("bet500").GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (playerMoney < 100 || playerMoney - playerBet < 100)
        {
            GameObject.Find("bet100").GetComponent<UnityEngine.UI.Button>().interactable = false;
        } else
        {
            GameObject.Find("bet100").GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (playerMoney < 25 || playerMoney - playerBet < 25)
        {
            GameObject.Find("bet25").GetComponent<UnityEngine.UI.Button>().interactable = false;
        } else
        {
            GameObject.Find("bet25").GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (playerMoney < 10 || playerMoney - playerBet < 10)
        {
            GameObject.Find("bet10").GetComponent<UnityEngine.UI.Button>().interactable = false;
        } else
        {
            GameObject.Find("bet10").GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (playerMoney - playerBet < 1)
        {
            GameObject.Find("bet1").GetComponent<UnityEngine.UI.Button>().interactable = false;
            if(playerMoney <= 0)
            {
                GameObject.Find("Spin").GetComponent<UnityEngine.UI.Button>().interactable = false;
            } else
            {
                GameObject.Find("Spin").GetComponent<UnityEngine.UI.Button>().interactable = true;
            }
        } else
        {
            GameObject.Find("bet1").GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
    }

    private void _checkPlayerBet()
    {
        if(playerBet > playerMoney)
        {
            playerBet = playerMoney;
        }
        showAllMoney();
        _checkPlayerMoney();
    }

    public void betPlayerBetOne()
    {
        playerBet += 1;
        _checkPlayerBet();
    }

    public void betPlayerBetTen()
    {
        playerBet += 10;
        _checkPlayerBet();
    }

    public void betPlayerBetTwentyfive()
    {
        playerBet += 25;
        _checkPlayerBet();
    }

    public void betPlayerBetHundred()
    {
        playerBet += 100;
        _checkPlayerBet();
    }

    public void betPlayerBetFivehundred()
    {
        playerBet += 500;
        _checkPlayerBet();
    }

    public void playSpinSound()
    {
        AudioSource.PlayClipAtPoint(spinSound, transform.position);
    }

    private void _betLineCheckerFirst()
    {
        GameObject.Find("1stSymbol").GetComponent<UnityEngine.SpriteRenderer>().sprite = _betLineChecker(betLine[0]);
    }

    private void _betLineCheckerSecond()
    {
        GameObject.Find("2ndSymbol").GetComponent<UnityEngine.SpriteRenderer>().sprite = _betLineChecker(betLine[1]);
    }

    private void _betLineCheckerThird()
    {
        GameObject.Find("3thSymbol").GetComponent<UnityEngine.SpriteRenderer>().sprite = _betLineChecker(betLine[2]);
    }

    private Sprite _betLineChecker(string betLine)
    {
        switch(betLine)
        {
            case "Seven":
                return seven;
            case "Grapes":
                return grape;
            case "Banana":
                return banana;
            case "Orange":
                return orange;
            case "Bell":
                return bell;
            case "Cherry":
                return cherry;
            case "Bar":
                return bar;
            default:
                return blank;
        }
    }
}
