using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimulacroOrientaciones : MonoBehaviour
{
    public string NombreAlumno;
    public int añoEscolar;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if(NombreAlumno == "")
        {
            Debug.Log("El nombre no puede estar vacío");
            return;
        }
        if (añoEscolar < 1 || añoEscolar > 5)
        {
            Debug.Log("Año ingresado no válido");
            return;
        }
        if(orientacion != "T" && orientacion != "M" && orientacion != "G" && orientacion != "H" && orientacion != "D")
        {
            Debug.Log("Solo puede ingresar T, D, G, M o H");
            return;
        }
        if (añoEscolar < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
            return;
        }

        Debug.Log("Muchas gracias " + NombreAlumno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
