using UnityEngine;

public class TriggerDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HeartSystem heart =
                collision.gameObject.GetComponent<HeartSystem>();

            Player player =
                collision.gameObject.GetComponent<Player>();

            if (heart != null)
            {
                heart._vida--;
            }

            if (player != null)
            {
                player.animator.SetTrigger("takeDamage");
            }
        }
    }
}
