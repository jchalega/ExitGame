using UnityEngine;
using UnityEngine.SceneManagement;

public class protalFimdeGame : MonoBehaviour
{
    private string TelaFinal;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("TelaFinal");
        }
    }
}