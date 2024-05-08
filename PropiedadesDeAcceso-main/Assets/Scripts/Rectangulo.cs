using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    [Header("Scripts")]
    public CanvasManager canvasManager;
    public Cubo cubo;

    private Animator animator;



    void Start()
    {
        animator = GetComponent<Animator>();
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cubo")) 
        {
            animator.SetBool("Saludando", true);

            canvasManager.CambiarDialogo(canvasManager.dialogoRectangulo, "¡¡Hola, " + cubo.Nombre + "!!");
            canvasManager.ActivarGloboDeDialogo(canvasManager.globoRectangulo, true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            animator.SetBool("Saludando", false);
            canvasManager.ActivarGloboDeDialogo(canvasManager.globoRectangulo, false);
        }
    }
}
