using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    
    public void Jogar(){
        SceneManager.LoadScene("Minigame");
    }

    public void Sair(){
        Application.Quit();
    }
}
