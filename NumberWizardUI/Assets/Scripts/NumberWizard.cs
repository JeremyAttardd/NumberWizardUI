using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class NumberWizard : MonoBehaviour {


    // Declare 2 integer variables
    int min = 1;
    int max = 1001;
    int guess = 500;
    int maxNumberOfTries = 10;

    public Text guessText;

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(min, max);

        guessText.text = guess.ToString();

        maxNumberOfTries--;
        if (maxNumberOfTries == 0) // If AI does not guess the number in 10 tries
        {
            SceneManager.LoadScene("Win"); // Load Win Scene
        }
    }
                            
    // Use this for initialization
    void Start() {

        }
	
	
}
