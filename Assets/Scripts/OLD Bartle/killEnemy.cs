using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class killEnemy : MonoBehaviour, IBartleScorable
{
    public BartleScoringRuleSO scoringRule;

    public string GetActionID() => scoringRule.actionID; //Recupere le nom de l'action via SO

    public BartleScoreData GetScoreData() => new BartleScoreData
    {
        Killer = scoringRule.scoreKiller,
        Achiever = scoringRule.scoreAchiever,
        Explorer = scoringRule.scoreExplorer,
        Socializer = scoringRule.scoreSocializer
    };


    private void OnDeath()
    {
        BartleEventSystem.RaiseScorableAction(this); //annonce la mort de l'ennemie a l'event qui fait son role de relais
    }
}
