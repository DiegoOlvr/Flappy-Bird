using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cano;
    public float altura;
    public float tempo;
    private float tempo_atual;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        float altura_y = Random.Range(-altura, altura);
        Vector3 posicao_cano = new Vector3(transform.position.x, altura_y, 0f);
        Instantiate(cano, posicao_cano, transform.rotation);
    }

    void FixedUpdate()
    {
        tempo_atual += Time.deltaTime;
        if (tempo_atual > tempo)
        {
            Spawn();
            tempo_atual = 0f;
        }
    }
}
