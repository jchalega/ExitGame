using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int vida;

    [SerializeField]
    public int vidaMaxima;

    public AudioClip damageSound;

    public AudioClip deathSound;

    private AudioSource sfxAudio;

    private bool morreu = false;

    void Start()
    {
        sfxAudio = GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {
        if (morreu)
            return;

        vida -= damage;

        Debug.Log("Vida atual: " + vida);

        // SOM DE DANO
        if (damageSound != null)
        {
            sfxAudio.PlayOneShot(damageSound);
        }

        if (vida <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        morreu = true;

        vida = 0;

        // SOM DE MORTE
        if (deathSound != null)
        {
            sfxAudio.PlayOneShot(deathSound);
        }

        GetComponent<Player>().enabled = false;

        Destroy(gameObject, 2f);
    }
}