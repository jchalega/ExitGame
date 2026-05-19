using System.Collections;
using UnityEngine;
using TMPro;

public class npc : MonoBehaviour
{
    public GameObject caixaDialogo;
    public TMP_Text textoDialogo;

    [TextArea(4, 6)]
    public string falaNPC;

    public float velocidade = 0.03f;

    private Coroutine animacaoTexto;

    private bool dialogoAberto = false;

    private void Start()
    {
        caixaDialogo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        if (dialogoAberto) return;

        dialogoAberto = true;

        caixaDialogo.SetActive(true);

        if (animacaoTexto != null)
        {
            StopCoroutine(animacaoTexto);
        }

        animacaoTexto = StartCoroutine(TypeText(falaNPC));
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        dialogoAberto = false;

        caixaDialogo.SetActive(false);

        if (animacaoTexto != null)
        {
            StopCoroutine(animacaoTexto);
        }

        textoDialogo.text = "";
    }

    IEnumerator TypeText(string texto)
    {
        textoDialogo.text = "";

        foreach (char letra in texto)
        {
            textoDialogo.text += letra;

            yield return new WaitForSeconds(velocidade);
        }
    }
}