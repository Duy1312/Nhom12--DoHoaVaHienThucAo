using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

   // Declare variables for Lap Complete trigger object
    public GameObject LapCompleteTrig;
    // Declare variables for Half Lap trigger object
    public GameObject HalfLapTrig;
    // Declare variables for Minute Display object
    public GameObject MinuteDisplay;
    // Declare variables for Second Display object
    public GameObject SecondDisplay;
    // Declare variables for Millisecond Display object
    public GameObject MilliDisplay;
    // Declare variables for Lap Time Box object
    public GameObject LapTimeBox;
    // Declare variables for Lap Counter object
    public GameObject LapCounter;
    // Declare integer variable to count the number of laps completed
    public int LapsDone;
    // Declare float variable to store raw time
    public float RawTime;
    // Declare variables for Race Finish object
    public GameObject RaceFinish;
    
    void Update(){
       // Check if the number of laps completed is 1
        if(LapsDone == 1){
            // If so, activate the RaceFinish object
            RaceFinish.SetActive(true);
        }
    }
        // OnTriggerEnter method runs when an object enters a trigger collider
    void OnTriggerEnter()
    {
        LapsDone += 1;
        RawTime = PlayerPrefs.GetFloat("RawTime");
        if(LapTimeManager.RawTime <=RawTime){
            if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;
        }
        

        PlayerPrefs.SetInt("MinSave",LapTimeManager.MinuteCount);
        PlayerPrefs.SetInt("SecSave",LapTimeManager.SecondCount);
        PlayerPrefs.SetFloat("MilliSave",LapTimeManager.MilliCount);
         PlayerPrefs.SetFloat("RawTime",LapTimeManager.RawTime);

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.RawTime = 0;
        ///
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}