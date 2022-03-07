using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coletar_moeda : MonoBehaviour
{
    private int contador = 0;
    public Text pontos;
    public GameObject chavedentro;
    private int numerodemoedas;

    private void Awake()
    {
        numerodemoedas = GameObject.FindGameObjectsWithTag("Moeda").Length;
    }
    private void OnCollisionEnter(Collision objeto)
    {
        if (objeto.gameObject.CompareTag("Moeda"))
        {
            Destroy(objeto.gameObject);
            contador=contador+1;
            pontos.text = "Pontos: " + contador.ToString();
            GetComponent<AudioSource>().Play();

            if (contador == numerodemoedas)
            {
                chavedentro.gameObject.SetActive(true);
            }
        }

    }
}     
