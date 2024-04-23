using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public SpriteRenderer imagem;
    public Rigidbody2D fisica;
    public int velocidade;
    public bool tecla_espaco;
    public bool mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pular();
    }

    void Pular()
    {
        tecla_espaco = Input.GetKeyDown("space");
        mouse = Input.GetMouseButtonDown(0);

        if (tecla_espaco || mouse)
        {
            fisica.velocity = Vector2.up * velocidade;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
          
        if (collision.gameObject.CompareTag("Cano"))
        {
            Destroy(gameObject);
            Controller.acesso.Mostrar_game_over();
        }
        if (collision.gameObject.CompareTag("Meio"))
        {
            Controller.acesso.Ganhar_pontos();
        }
    }

    
}
