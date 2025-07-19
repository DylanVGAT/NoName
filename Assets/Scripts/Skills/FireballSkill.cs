using UnityEngine;

public class FireballSkill : Skill
{
    public GameObject fireballPrefab;

    public FireballSkill(SkillData data, GameObject prefab) : base(data)
    {
        fireballPrefab = prefab;
    }

    public override void Activate(GameObject user)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 firePoint = user.transform.position;
        Vector2 direction = (mousePos - firePoint).normalized;

        GameObject fireball = GameObject.Instantiate(fireballPrefab, user.transform.position, Quaternion.identity);

        fireball.GetComponent<Projectile>().Init(direction);
    }
}
