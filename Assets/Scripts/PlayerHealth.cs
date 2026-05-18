using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
     public int vida;
    [SerializeField] public int vidaMaxima;
    public bool isPaused =false;

    private void Update()
    {
        DeadState();
    }
    public void TakeDamage(int damage)
    {
        vida -= damage;
        Debug.Log("Vida atual: " + vida);

        if (vida <= 0)
        {
            GetComponent<Player>().enabled = false;

            Destroy(gameObject, 0.5f);
        }
    }
    public void DeadState()
    {
        if (vida <= 0)
        {
            GetComponent<Player>().enabled = false;
            Destroy(gameObject, 0f);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}