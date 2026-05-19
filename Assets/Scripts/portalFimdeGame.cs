using UnityEngine;
using UnityEngine.SceneManagement;

public class protalFimdeGame : MonoBehaviour
{
    public string novaFase;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(novaFase);
        }
    }
}