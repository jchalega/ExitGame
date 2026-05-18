using UnityEngine;

public class HamburgerCollectible : MonoBehaviour
{
    public int value = 1;

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

            Destroy(gameObject);
        }
    }
}