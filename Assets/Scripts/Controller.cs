using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public int score;
    public static Controller acesso;
    public Text texto_pontuacao;
    public GameObject tela_derrota;
    public bool gameover;

    // Start is called before the first frame update
    void Start()
    {
        acesso = this;
        gameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ganhar_pontos()
    {
        score++;
        Atualizar_pontos();
    }

    void Atualizar_pontos()
    {
        texto_pontuacao.text = score.ToString();
    }

    public void Mostrar_game_over()
    {
        tela_derrota.SetActive(true);
        Game_over();
        Time.timeScale = 0;
    }

    public bool Game_over()
    {
        gameover = true;
        return gameover;
    }
}
