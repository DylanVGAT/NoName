using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartleScoreTracker
{
    public BartleScoreData totalScore = new BartleScoreData();

    public void AddScore(BartleScoreData newScore)
    {
        totalScore.Killer += newScore.Killer;
        totalScore.Achiever += newScore.Achiever;
        totalScore.Explorer += newScore.Explorer;
        totalScore.Socializer += newScore.Socializer;
    }
}
