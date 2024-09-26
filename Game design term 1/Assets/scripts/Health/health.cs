using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Invoke ("GameOver", 5);

        }

    }
}
private void GameOver()
{
    SceneManager.LoadSceneAsync(4);
}
public void AddHealth(float _value)
{
    currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);

}

}
