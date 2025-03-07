using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Cargarnivel : MonoBehaviour // Incluir este script al EventSystem para incluirlo en el Onclick del Button de la escena.
{
    public GameObject menuPausa;
    bool pausado = false;


    public void corgarescena (string escena){ // Void publico, para poder acceder a el
        Application.LoadLevel(escena); // Linea de comando cargar escena (puedes usar numeros como numeros de la build) Necesitas poner las escenas en la build
    }

    //public void OnPointerEnter(PointerEventData eventData)
    //{
       
    //}

    public void OpenPause()
    {
        menuPausa.SetActive(true);
        pausado = true;
    }
    public void ClosePause()
    {
        if (pausado == true)
        {
            menuPausa.SetActive(false);
        }
        pausado = false;

    }
}
