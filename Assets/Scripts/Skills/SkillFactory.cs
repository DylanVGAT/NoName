using UnityEngine;

public class SkillFactory
{
    private SkillPrefabDatabase prefabDatabase;

    public SkillFactory(SkillPrefabDatabase database)
    {
        prefabDatabase = database;
    }

    public Skill CreateSkill(SkillData data)
    {
        switch (data.id)
        {
            case "fireball":
                return new FireballSkill(data, prefabDatabase.GetPrefab("fireball"));
            case "dash":
                return new DashSkill(data);
            // ...
            default:
                Debug.LogError($"Skill ID inconnu : {data.id}");
                return null;
        }
    }
}
