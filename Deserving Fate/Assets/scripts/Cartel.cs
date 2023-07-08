using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cartel : MonoBehaviour
{
    public GameObject informacion;
    public GameObject mostrar;

    public bool informacionHabilitada;
    public bool informacionMostrar;

    public LayerMask personaje;

    // Start is called before the first frame update
    void Start()
    {
        informacion.gameObject.SetActive(false);
        mostrar.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        informacionHabilitada = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);
        
        if (informacionHabilitada == true)
        {
            informacion.gameObject.SetActive(true);
        }
        if (informacionHabilitada == false)
        {
            informacion.gameObject.SetActive(false);
        }

        informacionMostrar = Physics2D.OverlapCircle(this.transform.position, 1f, personaje);
        
        if (informacionMostrar == true && Input.GetKeyDown(KeyCode.J))
        {
            mostrar.gameObject.SetActive(true);
        }
        if (informacionMostrar == false)
        {
            mostrar.gameObject.SetActive(false);
        }
    }
}
