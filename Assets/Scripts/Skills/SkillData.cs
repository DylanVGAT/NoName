using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSkill", menuName = "Skills/SkillData")]
public class SkillData : ScriptableObject
{
    public string id;
    public string skillTypeName;

    public KeyCode activationKey;
    public Sprite icon;
    public float value; //dégâts, vitesse, etc.
}
