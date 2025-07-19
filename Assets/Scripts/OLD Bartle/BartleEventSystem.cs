using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BartleEventSystem
{
    public static event Action<IBartleScorable> OnScorableAction;

    //Cette methode est appele par toutes les methodes qui veulent annoncer quelque chose, comme la mort d'un ennemie
    public static void RaiseScorableAction(IBartleScorable action) 
    {
        OnScorableAction?.Invoke(action); //Appelle l'interface qui recupere via le SO le nb de pts et le nom de l'action
    }
}
