using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Bartle/ScoringRule")]
public class BartleScoringRuleSO : ScriptableObject
{
    public int scoreKiller, scoreExplorer, scoreAchiever, scoreSocializer; //Les scores
    public string actionID; // Le nom que je donne a l'action qui donne des pts

}
