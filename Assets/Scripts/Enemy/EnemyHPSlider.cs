using UnityEngine;
using UnityEngine.UI;

public class EnemyHPSliderS : MonoBehaviour
{

    public float health;
    public float maxHealth;

    public GameObject healthBarUI;
    public Slider sliderS;

    void Start()
    {
        health = maxHealth;
        sliderS.value = CalculateHealth();
    }
    void Update()
    {

        sliderS.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
    float CalculateHealth()
    {
        return health / maxHealth;
    }
}
