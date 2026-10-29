using System;
using UnityEngine;

public class PlayerFallDetector : MonoBehaviour
{
    [SerializeField] private float fallLimit = -15f; // Граница падения
    private bool isDead = false;                     // Чтобы событие не срабатывало миллион раз при падении

    // СОБЫТИЕ: на него смогут подписываться любые другие скрипты
    public static event Action OnPlayerDied;

    void Update()
    {
        // Если упали ниже порога и мы еще не считаемся мертвыми
        if (transform.position.y < fallLimit && !isDead)
        {
            isDead = true; // Фиксируем смерть, чтобы не спамить событием
            
            // Запускаем событие (вопросительный знак защищает от ошибки, если никто не подписан)
            OnPlayerDied?.Invoke();
        }
    }

    // Если персонажа возродили, сбрасываем флаг смерти
    public void ResetDeathState()
    {
        isDead = false;
    }
}