using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	public Text GuessedNumberText;
	public Text RemainingGuessesText;

	const int MaxNumber = 1000;
	const int MinNumber = 0;
	int maxGuessAllowed;
	int maxNumber;
	int minNumber;
	int guessedNumber;

	// Use this for initialization
	void Start () {
		StartGame();
	}

	private void StartGame()
	{
		maxGuessAllowed = 10;
		maxNumber = MaxNumber + 1; // plus one to handle max number as guessed number.
		minNumber = MinNumber;

		print("Welcome to NumberWizard!");
		print("Please choose a number but don't tell me! I can guess it for you");
		print("You can only choose between " + MinNumber + " to " + MaxNumber);
		RandomGuess();
	}
		

	public void Lower()
	{
		maxNumber = guessedNumber;
		RandomGuess();
	}

	public void Higher()
	{
		minNumber = guessedNumber;
		RandomGuess();
	}

	private void RandomGuess()
	{
		guessedNumber = Random.Range(minNumber, maxNumber);
		GuessedNumberText.text = "Is " + guessedNumber + " your number?";
		maxGuessAllowed = maxGuessAllowed - 1;
		RemainingGuessesText.text = (maxGuessAllowed <= 1 ? "Guess" : "Guesses") + " remaining : " + maxGuessAllowed;
		if (maxGuessAllowed < 0) {
			SceneManager.LoadScene ("Win");
		}
	}

	private int FindMid(int min, int max)
	{
		return (min + max) / 2;
	}
}