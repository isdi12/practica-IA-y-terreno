using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    [SerializeField] public float health = 200;

    private float MAX_HEALTH = 200;
    [SerializeField] private LifeBar lifeBar;
    

    private void Start()
    {
        MAX_HEALTH = health;
        lifeBar.StartLifeBar(health / MAX_HEALTH);
        health = Mathf.Clamp(health, 0, 200);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Damage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            // Heal(10);
        }
    }

    public void Damage(float amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;
        lifeBar.ChangeActualLife(health / MAX_HEALTH);
        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if (wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }

    private void Die()
    {

        Debug.Log("I am Dead!");
        Destroy(gameObject);


    }
}
