using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientaciones : MonoBehaviour
{
    public string nombreAlumno;
    public int añoDelAlumnno;
    public string orientacionPertenece;

    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "")
        {
            Debug.Log("El nombre del alumno no puede estar vaciio");
            return;
        } else if (añoDelAlumnno > 5 || añoDelAlumnno < 1)
        {
            Debug.Log("Año ingresado no valido");
            return;
        }
        if (orientacionPertenece != "T" && orientacionPertenece != "D" && orientacionPertenece != "G" && 
            orientacionPertenece != "T" && orientacionPertenece != "H")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
        if (añoDelAlumnno > 5 || añoDelAlumnno <3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        } 

        Debug.Log("Muchas Gracias " + nombreAlumno + "!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

