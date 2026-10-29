using System;
using UnityEngine;

public class health: MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {           
            TakeDamage(20);
            
            if (IsAlive() == false)
            {
               Debug.Log("Персонаж мертв"); 
            }
        }

    }

    public void TakeDamage (int damage)
    {
        currentHealth = currentHealth - damage;
        Debug.Log($"Игрок получил {damage} урона");
    }

    public bool IsAlive()
    {
        return currentHealth > 0;
    }
}

