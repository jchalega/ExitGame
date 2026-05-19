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

    private void Start()
    {
        falaNPC = "Precisamos de mais suprimentos urgente.\nSuba as escadas e procure alguns lanches. Nao morra!!";

        textoDialogo.text = "";
        caixaDialogo.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        Debug.Log(gameObject.name + " -> " + falaNPC);

        caixaDialogo.SetActive(true);

        if (animacaoTexto != null)
            StopCoroutine(animacaoTexto);

        animacaoTexto = StartCoroutine(TypeText(falaNPC));
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        caixaDialogo.SetActive(false);

        if (animacaoTexto != null)
            StopCoroutine(animacaoTexto);
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