using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    [Header("Nombre")]

    private string nombre = "Cubito";
    public string Nombre { get => nombre; set => nombre = value; }



    [Header("Movimiento")]

    float velocidad = 3;

    float horizontal;

    Vector2 vectorDeMovimiento;



    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");

        vectorDeMovimiento = new Vector2(horizontal, 0);
        vectorDeMovimiento.Normalize();

        transform.Translate(vectorDeMovimiento * Time.deltaTime * velocidad);
    }
}
