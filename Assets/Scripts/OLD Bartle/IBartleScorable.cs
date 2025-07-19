using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBartleScorable
{

    string GetActionID(); //Oblige les classes a avoir cette methode qui obtiens le nom de l'action (via le SO)
    BartleScoreData GetScoreData(); //Oblige les classes a avoir le nb de pts que l'action donne (via le SO)
    
}
