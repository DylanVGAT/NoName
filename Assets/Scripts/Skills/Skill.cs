using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    public SkillData data;

    public Skill(SkillData data) { this.data = data; }

    public abstract void Activate(GameObject user);
}
