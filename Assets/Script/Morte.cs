using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Morte : MonoBehaviour
{
    public Text mortandade;
    private void OnCollisionEnter(Collision jogador)
    {
        if (jogador.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Stop();
            Time.timeScale = 0;
            GetComponent<AudioSource>().Play();
            mortandade.gameObject.SetActive(true);
            
        }
    }

}
