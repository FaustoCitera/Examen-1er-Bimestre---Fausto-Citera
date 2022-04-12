using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Una flota de taxis tiene una cantidad determinada de unidades.
//Se calcula que cada unidad recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km.
//Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 110 km por unidad.
//Teniendo en cuenta que el litro de combustible cuesta $130, 
//debemos hacer un programa que nos permita calcular el costo del combustible para una flota completa de taxis en un 
//período de días determinado.
//Se requiere el ingreso por Inspector de la cantidad total de días y una cantidad de días de lluvia a tener en cuenta.
//El programa debe cumplir los siguientes requerimientos:
//El programa debe devolver la información calculada mediante un mensaje en el siguiente formato:
//“Una flota de[cantidadDeUnidades] unidades trabajando durante [periodoDeDias] días implicará un gasto de[costoTotalCombustible] pesos en concepto de combustible”.
//El programa debe devolver un mensaje de error y no realizar ningún cálculo si la cantidad de días total es menor que 5 o si la cantidad de días de lluvia es negativa o mayor que la cantidad total de días. 

public class Tema4 : MonoBehaviour
{
	public int CantDeDias;
	public int CantDeDiasDeLluvia;
	public int CantidadDeTaxis;
    // Start is called before the first frame update
    void Start()
    {
		int Precio = 130;
		int PrecioPorReccoridoDeDia;
		PrecioPorReccoridoDeDia = (CantidadDeTaxis * (CantDeDias - CantDeDiasDeLluvia) * 6 * Precio) + (CantidadDeTaxis * CantDeDiasDeLluvia * 7 * (Precio + 43)) ;
		Debug.Log("Una flota de " + CantidadDeTaxis + " unidades trabajando durante " + CantDeDias + " días implicará un gasto de " + PrecioPorReccoridoDeDia + " pesos en concepto de combustible ");

		if (CantDeDias < 5)
		{
			Debug.Log("Ingreso de dias no dalido");
		}
		else if (CantDeDiasDeLluvia < 0 || CantDeDiasDeLluvia > CantDeDias)
		{
			Debug.Log("Ingreso de dias de lluvia no valido");
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
