using UnityEngine;

public class MusicController : MonoBehaviour
{
    [Header("Компоненты")]
    [Tooltip("Перетащите сюда ваш аудиофайл (трек)")]
    public AudioClip musicClip;

    private AudioSource audioSource;

    void Start()
    {
        // Проверяем, есть ли на объекте AudioSource, если нет — добавляем автоматически
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Назначаем трек и отключаем автовоспроизведение при старте игры
        audioSource.clip = musicClip;
        audioSource.playOnAwake = false; 
        audioSource.loop = true; // Сделайте false, если не нужно повторять музыку по кругу
    }

    void Update()
    {
        // Проверяем нажатие английской клавиши P
        if (Input.GetKeyDown(KeyCode.P))
        {
            ToggleMusic();
        }
    }

    void ToggleMusic()
    {
        if (audioSource.clip == null)
        {
            Debug.LogWarning("Музыкальный трек не назначен в инспекторе!");
            return;
        }

        // Если играет — ставим на паузу, если нет — запускаем
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
            Debug.Log("Музыка на паузе");
        }
        else
        {
            audioSource.Play();
            Debug.Log("Музыка играет");
        }
    }
}