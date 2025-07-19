using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Skills/Skill Prefab Database")]
public class SkillPrefabDatabase : ScriptableObject
{
    public List<SkillPrefabEntry> entries;

    private Dictionary<string, GameObject> prefabMap;

    private void OnEnable()
    {
        prefabMap = new Dictionary<string, GameObject>();
        foreach (var entry in entries)
        {
            prefabMap[entry.skillId] = entry.prefab;
        }
    }

    public GameObject GetPrefab(string skillId)
    {
        if (prefabMap.TryGetValue(skillId, out var prefab))
            return prefab;
        Debug.LogWarning($"Prefab not found for skill ID: {skillId}");
        return null;
    }
}