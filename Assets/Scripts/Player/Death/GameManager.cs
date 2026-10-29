using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // При включении объекта — ПОДПИСЫВАЕМСЯ на событие
    private void OnEnable()
    {
        PlayerFallDetector.OnPlayerDied += HandlePlayerDeath;
    }

    // При выключении объекта — ОБЯЗАТЕЛЬНО ОТПИСЫВАЕМСЯ (чтобы не было утечек памяти)
    private void OnDisable()
    {
        PlayerFallDetector.OnPlayerDied -= HandlePlayerDeath;
    }

    // ХЕНДЛЕР (Метод-обработчик): сработает сам, когда игрок упадет
    private void HandlePlayerDeath()
    {
        Debug.Log("GameManager: Перезагружаю сцену...");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}