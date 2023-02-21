using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour {

    public static int MinuteCount;
    public static int SecondCount;
    public static float MilliCount;
    public static string MilliDisplay;

    public GameObject MinuteBox;
    public GameObject SecondBox;
    public GameObject MilliBox;
    public static float RawTime;

    // Update is called once per frame
    void Update () {

       // Increase MilliCount by 10 times of Time.deltaTime per frame
MilliCount += Time.deltaTime * 10;
RawTime += Time.deltaTime;
// Convert MilliCount to String
MilliDisplay = MilliCount.ToString("F0");
// Update MilliBox with MilliDisplay value
MilliBox.GetComponent<Text>().text = "" + MilliDisplay;

// If MilliCount is more than or equal to 10,
// reset the MilliCount and increase the SecondCount by 1
if (MilliCount >= 10)
{
    MilliCount = 0;
    SecondCount += 1;
}

// If SecondCount is less than or equal to 9, add "0" in front of the count
// Else, display just the SecondCount
if (SecondCount <= 9)
{
    SecondBox.GetComponent<Text>().text = "0" + SecondCount + ".";
}
else
{
    SecondBox.GetComponent<Text>().text = "" + SecondCount + ".";
}

// If SecondCount is more than 60,
// reset the SecondCount and increase the MinuteCount by 1
if (SecondCount >= 60)
{
    SecondCount = 0;
    MinuteCount += 1;
}

// If MinuteCount is less than or equal to 9, add "0" in front of the count
// Else, display just the MinuteCount
if (MinuteCount <= 9)
{
    MinuteBox.GetComponent<Text>().text = "0" + MinuteCount + ":";
}
else
{
    MinuteBox.GetComponent<Text>().text = "" + MinuteCount + ":";
}

    }

}

