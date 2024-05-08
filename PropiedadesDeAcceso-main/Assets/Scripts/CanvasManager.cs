using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [Header("Globos de diálogos")]
    public GameObject globoRectangulo;
    public GameObject globoCirculo;

    [Header("Texto")]
    public TextMeshProUGUI dialogoRectangulo;
    public TextMeshProUGUI dialogoCirculo;



    void Start()
    {
        ActivarGloboDeDialogo(globoCirculo, false);
        ActivarGloboDeDialogo(globoRectangulo, false);
    }



    public void ActivarGloboDeDialogo(GameObject globo, bool aparecerEnPantalla)
    {
        globo.SetActive(aparecerEnPantalla);
    }

    public void CambiarDialogo(TextMeshProUGUI texto, string dialogo) 
    { 
        texto.text = dialogo;
    }

}
