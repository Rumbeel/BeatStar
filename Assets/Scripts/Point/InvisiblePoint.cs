using UnityEngine;

public class InvisiblePoint : MonoBehaviour
{
    [Range(0f, 1f)]
    public float targetAlpha = 0.3f;

    void Start()
    {
        if (TryGetComponent<SpriteRenderer>(out SpriteRenderer sprite))
        {
            Color color = sprite.color;
            color.a = targetAlpha;
            sprite.color = color;
        }

    }
}
