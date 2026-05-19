using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int vida;

    [SerializeField]
    public int vidaMaxima;

    public AudioClip damageSound;
    public AudioClip deathSound;

    private AudioSource sfxAudio;

    private bool morreu = false;

    [Header("GAME OVER")]
    public GameObject gameOverPanel;

    public string cenaBase = "SceneInicial";

    void Start()
    {
        sfxAudio = GetComponent<AudioSource>();

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
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

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            rb.linearVelocity = Vector2.zero;
        }

        StartCoroutine(GameOverRoutine());
    }

    IEnumerator GameOverRoutine()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        if (sr != null)
        {
            sr.enabled = false;
        }

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene(cenaBase);
    }
}