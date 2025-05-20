using System;
using Unity.VisualScripting;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float velocidade = 10;
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 posicao = transform.position;
        
        //esquerda X-
        
        if (Input.GetKey(KeyCode.A))
        {
            posicao.x = posicao.x - velocidade * Time.deltaTime;
        }
        
        //direita X+

        if (Input.GetKey(KeyCode.D))
        {
            posicao.x = posicao.x + velocidade * Time.deltaTime;
        }
        
        transform.position = posicao;
    }
}