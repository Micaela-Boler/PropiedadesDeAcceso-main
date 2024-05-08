using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
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

            if (cubo.Nombre == "Cubito")
            {
                cubo.Nombre = "Circulo";
                canvasManager.CambiarDialogo(canvasManager.dialogoCirculo, "No me gusta tu nombre. Ahora te vas a llamar " + cubo.Nombre);

                animator.SetBool("CambioDeNombre", true);
            }
            else
            {
                canvasManager.CambiarDialogo(canvasManager.dialogoCirculo, "Me gusta tu nombre");
                animator.SetTrigger("LindoNombre");
            }


            canvasManager.ActivarGloboDeDialogo(canvasManager.globoCirculo, true);
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cubo"))
        {
            canvasManager.ActivarGloboDeDialogo(canvasManager.globoCirculo, false);
            animator.SetBool("CambioDeNombre", false);
        }
    }
}
