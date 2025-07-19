using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BartleManagerSystem : MonoBehaviour
{
    private BartleScoreTracker scoreTracker = new BartleScoreTracker();

    private void OnEnable()
    {
        BartleEventSystem.OnScorableAction += HandleScoring;
    }

    private void OnDisable()
    {
        BartleEventSystem.OnScorableAction -= HandleScoring;
    }

    //Methode qui  incrementer le score selon les infos donne par l'event On Enable
    private void HandleScoring(IBartleScorable scorable)
    {
        BartleScoreData data = scorable.GetScoreData();
        scoreTracker.AddScore(data);
        Debug.Log($"+{scorable.GetScoreData()} pour {scorable.GetActionID()} !");
    }

}
