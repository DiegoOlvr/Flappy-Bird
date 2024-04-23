using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public Rigidbody2D fisica;
    public int velocidade;
    public float posicao_morte;
    private float posicao_cano;
    public bool game_over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Desativar_cano();
    }

    void Mover()
    {
        posicao_cano = transform.position.x;
        fisica.velocity = Vector2.left * velocidade;
        if (posicao_cano < posicao_morte)
        {
            Destroy(gameObject);
        }
    }

    void Desativar_cano()
    {
        game_over = Controller.acesso.Game_over();
        if (game_over)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
