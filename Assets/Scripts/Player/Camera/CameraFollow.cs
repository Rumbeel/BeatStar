using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Слежение")]
    public Transform target;            // Ссылка на персонажа (кого преследовать)
    [Range(0.01f, 1f)]
    public float smoothTime = 0.2f;     // Насколько сильное "опоздание" (чем больше число, тем ленивее камера)

    [Header("Смещение")]
    public Vector3 offset = new Vector3(0f, 1f, -10f); // Смещение относительно игрока (Z ОБЯЗАТЕЛЬНО -10)

    private Vector3 velocity = Vector3.zero;

    // ВАЖНО: Камеру двигаем в LateUpdate, чтобы убрать дрожание!
    private void LateUpdate()
    {
        if (target == null) return;

        // Вычисляем идеальную точку, где должна быть камера
        Vector3 targetPosition = target.position + offset;

        // Плавно двигаем камеру к этой точке с опозданием
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}