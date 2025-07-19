using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartleScoreData
{
    public int Killer;
    public int Achiever;
    public int Explorer;
    public int Socializer;

    public override string ToString()
    {
        return $"{Killer}K / {Achiever}A / {Explorer}E / {Socializer}S";
    }
}


