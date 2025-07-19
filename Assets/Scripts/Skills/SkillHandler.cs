using System.Collections.Generic;
using UnityEngine;

public class SkillHandler : MonoBehaviour
{
    [SerializeField] private SkillPrefabDatabase prefabDatabase;
    [SerializeField] private List<SkillData> skillConfigs;

    private List<Skill> skills = new List<Skill>();
    private SkillFactory factory;

    void Start()
    {
        factory = new SkillFactory(prefabDatabase);

        foreach (var config in skillConfigs)
        {
            Skill skill = factory.CreateSkill(config); 
            if (skill != null)
                skills.Add(skill);
        }
    }

    void Update()
    {
        foreach (Skill skill in skills)
        {
            if (Input.GetKeyDown(skill.data.activationKey))
            {
                skill.Activate(gameObject);
            }
        }
    }
}
