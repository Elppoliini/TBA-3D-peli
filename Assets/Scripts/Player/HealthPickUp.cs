using UnityEngine;
using UnityEngine.UI;

public class HealthPickUp : MonoBehaviour
{
    PlayerHealth playerHealth;
    public Slider healthSlider;
    public int healthBonus = 15;

    void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();

    }
    void OnTriggerEnter(Collider other2)
    {
        if (playerHealth.currentHealth < playerHealth.startingHealth)
        {
            Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthBonus;
            healthSlider.value = playerHealth.currentHealth;
        }
    }
}