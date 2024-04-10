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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
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
}
