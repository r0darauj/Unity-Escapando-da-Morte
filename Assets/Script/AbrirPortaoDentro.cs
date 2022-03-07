using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrirPortaoDentro : MonoBehaviour
{
    public GameObject gate;
    private void OnCollisionEnter(Collision jogador)
    {
        if (jogador.gameObject.CompareTag("Player"))
        {
            Destroy(gate.gameObject);
            Destroy(this.gameObject);
        }
    }
}
