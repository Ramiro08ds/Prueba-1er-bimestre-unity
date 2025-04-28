using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantidadTaxis;
    public int cantidadDias;
    float costoTotal;
    int cantidadDecombustible;
    float precioPorLitro = 130;
    int kilometrosRecorridosxdia = 90;
    // Start is called before the first frame update
    void Start()
    {
        cantidadDecombustible = cantidadTaxis * cantidadDias * kilometrosRecorridosxdia/15;
        Debug.Log(cantidadDecombustible);
        if (cantidadDias < 5)
        {
            Debug.Log("cantidad de dias no valida");
            return;
        }
        else if (cantidadTaxis < 1)
        {
            Debug.Log("cantidad de taxis no valida");
            return;
        }
        else if (cantidadDecombustible < 100) {  
            costoTotal = cantidadDecombustible * precioPorLitro;
            Debug.Log("Una flota de " + cantidadTaxis + " unidades trabajando durante" + cantidadDias + "días implicará un gasto de " + costoTotal + " pesos en concepto de combustible");
        }
        else if (cantidadDecombustible >= 100)
        {
            costoTotal = cantidadDecombustible * precioPorLitro;
            costoTotal = costoTotal - (costoTotal / 20);
            Debug.Log("Una flota de " + cantidadTaxis + " unidades trabajando durante" + cantidadDias + "días implicará un gasto de " + costoTotal + " pesos en concepto de combustible con un descuento aplicado del 20%");
        }
        else
        {
            Debug.Log("error cambiar valores");
            return;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
