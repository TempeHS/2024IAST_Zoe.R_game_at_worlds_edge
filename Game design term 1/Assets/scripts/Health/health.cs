using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
[SerializeField] private float startingHealth;
public float currentHealth { get; private set; }
private Animator anim;
private bool riplmao; 

private void Awake()
{
    currentHealth = startingHealth;
    anim = GetComponent<Animator>();
}

public void TakeDamage(float _damage)
{
    currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

    if (currentHealth > 0)
    {
        //player is damaged
        //add iframes later :3
    }
    else
    {
        if(!riplmao)
        {
            anim.SetTrigger("die");
            GetComponent<PlayerMovement>().enabled = false;
            riplmao = true;
        }

    }
}
piblic void AddHealth(float _value)
{
    currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);

}

}
