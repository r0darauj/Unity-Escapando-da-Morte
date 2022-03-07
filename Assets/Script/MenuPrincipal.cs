using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void sair()
    {
        Application.Quit();
    }

    // Update is called once per frame
    public void jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
