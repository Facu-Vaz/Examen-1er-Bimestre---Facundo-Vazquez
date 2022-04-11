using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public string CodigoDelAnimal;
    public int DiasQueSeQueda;
    
    // Start is called before the first frame update
    void Start()
    {
        int gramosPorDia;
        if (DiasQueSeQueda < 3)
        {
            Debug.Log("El animal no puede quedarse menos de 3 dias");
            return;
        }

        if (CodigoDelAnimal == "G")
        {
            gramosPorDia = 300;
        }
        else if (CodigoDelAnimal == "PP")
        {
            gramosPorDia = 400;
        }
        else if (CodigoDelAnimal == "PG")
        {
            gramosPorDia = 700;
        }
        else
        {
            Debug.Log("El codigo no es valido");
            return;
        }

        int gramosTotales = gramosPorDia * DiasQueSeQueda;

        Debug.Log("Para ese período se necesitan " + gramosTotales + " gramos de alimento");
        Debug.Log("El costo total del alimento es de $" + ((gramosTotales / 100) * 80));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
