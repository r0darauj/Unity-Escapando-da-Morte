using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Fim : MonoBehaviour
{
    public Text fim;
    public Button voltar2;
    private void OnCollisionEnter(Collision jogador)
    {
        if (jogador.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().Play();
            Time.timeScale = 0;
            fim.gameObject.SetActive(true);
            
        }
    }
}
