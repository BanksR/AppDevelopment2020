using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Here we reference a UI Text element to display our score
    public Text ScoreText;
    private int score = 0;

    // This references the time slider UI element
    public Slider TimeSlider;
    // How long should our clicker game round last - with a private float to keep track of current time
    public float GameTime = 10;
    private float timer = 0f;
    // Here we reference a collection of UI elements that show/hide a back button and panel
    public GameObject BackButton;

    // Here we refence our count down timer gameobject
    public GameObject CountdownTimer;

    
    // A switch that indicates whether the game is playing or not
    private bool isPlaying = false;


	
	void Awake ()
    {
        // Here we initialise our variables to reset everything to zero, and hide the back button
        timer = 0;
        ScoreText.text = "0";
        score = 0;
        BackButton.SetActive(false);
    }
	
	
	void Update ()
    {
        // Update will increment our timer variable and control the flicking of the isPlaying bool switch
        if (isPlaying)
        {
            // If isPlaying is true, increment the timer and update the UI slider so it ticks down
            timer += Time.deltaTime;
            TimeSlider.value = 1- (timer / GameTime);

            if (timer >= GameTime)
            {
                // Once our timer has run out we set isPlaying to false, and unhide our back button so we
                // can navigate back to the main menu
                isPlaying = false;
                BackButton.SetActive(true);
            }
        }
	}

    public void InitGame()
    {
        // This function initialises all our variables and states - resetting them for the next round
        isPlaying = true;
        timer = 0;
        ScoreText.text = "0";
        score = 0;
        
    }

    public void AddToScore()
    {
        // This function is called when the player clicks the clicker button
        // We check the isPlaying bool to make sure you can't score after the time runs out
        if (isPlaying)
        {
            score++;
            ScoreText.text = score.ToString();
        }
    }

    public void StartGame()
    {
        // This function is called by our UI Start Game button
        timer = 0;
        ScoreText.text = "0";
        score = 0;

        // Invoke() is a hacky way to create time based function calls - not great to use, but works well in simple cases.
        // Coroutines are usually preferred
        
        Invoke("InitGame", 3);

        // Finally, we call the PlayAnim() function on the Countdown script on our CountDown gameobject
        CountdownTimer.GetComponent<Countdown>().PlayAnim();
    }
}
