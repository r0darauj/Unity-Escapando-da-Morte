using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VoltarIni : MonoBehaviour
{
    public void voltar()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
    }
}
