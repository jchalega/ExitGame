using UnityEngine;

public class HamburgerCollectible : MonoBehaviour
{
    public int value = 1;
    public AudioClip collectSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreSystem score =
                collision.GetComponent<ScoreSystem>();

            if (score != null)
            {
                score.AddHamburger(value);
            }

            GetComponent<Collider2D>().enabled = false;
            audioSource.PlayOneShot(collectSound);

            Destroy(gameObject, 0.3f);
        }
    }
}