using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 20f;
    public float maxHealth = 20f;

    public GameManager gameManager;


    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
        }

        gameManager.UpdateUI();
    }
}