using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public bool pasarnivel;
    public int indicenivel;

    void Start()
    {

    }
    void Update()
    {
        if (pasarnivel)
        {
            CambioDeEscena(indicenivel);
        }
    }


    public void CambioDeEscena(int indice)
    {

        SceneManager.LoadScene(indice);
    }
}