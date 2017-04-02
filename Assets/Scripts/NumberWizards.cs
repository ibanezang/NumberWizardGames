using UnityEngine;

public class NumberWizards : MonoBehaviour {

    const int MaxNumber = 10000;
    const int MinNumber = 0;
    int maxNumber;
    int minNumber;
    int guessedNumber;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    private void StartGame()
    {
        maxNumber = MaxNumber + 1; // plus one to handle max number as guessed number.
        minNumber = MinNumber;

        print("Welcome to NumberWizard!");
        print("Please choose a number but don't tell me! I can guess it for you");
        print("You can only choose between " + MinNumber + " to " + MaxNumber);
        PrintGuess();
    }
	

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Higher();
            PrintGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Lower();
            PrintGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Thanks for playing!");
        }
    }

    private void Lower()
    {
        maxNumber = guessedNumber;
    }
    private void Higher()
    {
        minNumber = guessedNumber;
    }

    private void PrintGuess()
    {
        guessedNumber = FindMid(minNumber, maxNumber);
        print(string.Format("Is the number lower or higher than {0}?", guessedNumber));
        print("Up = higher, Down = lower, Space = equal");
    }

    private int FindMid(int min, int max)
    {
        return (min + max) / 2;
    }
}