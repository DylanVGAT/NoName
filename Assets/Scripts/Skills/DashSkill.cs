using UnityEngine;

public class DashSkill : Skill
{
    public DashSkill(SkillData data) : base(data) { }

    public override void Activate(GameObject user)
    {
        var movementManager = user.GetComponent<MovementManager>();
        Vector2 dir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        movementManager.StartDash(dir);
        Debug.Log("Dash!");
    }
}
