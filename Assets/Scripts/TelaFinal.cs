using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    // Carrega a cena do menu principal
    public void IrParaMenu()
    {
        SceneManager.LoadScene("InicialMenu");
    }

    // Fecha o jogo
    public void SairDoJogo()
    {
        Debug.Log("Jogo encerrado.");

        // Funciona na versão compilada do jogo
        Application.Quit();

        // Fecha o Play Mode quando estiver testando no Editor da Unity
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}