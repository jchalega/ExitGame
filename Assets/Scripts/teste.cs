using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public float velocidade = 10f;

    private Rigidbody2D rb; // Mude para Rigidbody se estiver em 3D
    private Vector2 direcaoMovimento;

    void Start()
    {
        // Pega o componente de física do personagem
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura as teclas pressionadas (W, A, S, D ou Setas)
        float inputX = Input.GetAxisRaw("Horizontal");
        float inputY = Input.GetAxisRaw("Vertical");

        direcaoMovimento = new Vector2(inputX, inputY).normalized;
    }

    // FixedUpdate é o mais indicado para alterar o Rigidbody
    void FixedUpdate()
    {
        Andar();
    }

    void Andar()
    {
        // Aplica o movimento ao Rigidbody
        rb.MovePosition(rb.position + direcaoMovimento * velocidade * Time.fixedDeltaTime);
    }
}