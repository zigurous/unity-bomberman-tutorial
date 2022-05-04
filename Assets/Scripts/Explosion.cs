using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AnimatedSpriteRenderer start;
    public AnimatedSpriteRenderer middle;
    public AnimatedSpriteRenderer end;

    public void DestroyAfter(float seconds)
    {
        Destroy(gameObject, seconds);
    }

    public void SetActiveRenderer(AnimatedSpriteRenderer renderer)
    {
        start.enabled = false;
        middle.enabled = false;
        end.enabled = false;

        renderer.enabled = true;
    }

    public void SetDirection(Vector2 direction)
    {
        float angle = Mathf.Atan2(direction.y, direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }

}
