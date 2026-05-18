using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth =
                collision.gameObject.GetComponent<PlayerHealth>();

            Player player =
                collision.gameObject.GetComponent<Player>();

            if (playerHealth != null)
            {
                playerHealth.vida--;
            }

            if (player != null)
            {
                player.animator.SetTrigger("takeDamage");
            }
        }
    }
}
