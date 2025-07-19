using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 direction;

    public void Init(Vector2 dir)
    {
        direction = dir.normalized;
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
