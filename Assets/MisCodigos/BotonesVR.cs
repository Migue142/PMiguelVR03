using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BotonesVR : MonoBehaviour
{
    public InputActionReference Disparador;
    public InputActionReference Agarre;
    public InputActionReference BotonEje2D;

    private void Disparador_Presionado(InputAction.CallbackContext context)
    {
        print("Disparador ejecutado");
    }

    private void Disparador_Liberado(InputAction.CallbackContext context)
    {
        print("Disparador cancelado");
    }

    private void Agarre_Presionado(InputAction.CallbackContext context)
    {
        print("Agarre ejecutado");
    }

    private void Agarre_Liberado(InputAction.CallbackContext context)
    {
        print("Agarre cancelado");
    }
    private void BotonEje2D_Presionado(InputAction.CallbackContext context) 
    { 
        print("Boton Eje2D ejecutado"); 
    }
    private void BotonEje2D_Liberado(InputAction.CallbackContext context)
    {
        print("Boton Eje2D cancelado");
    }
    private void OnEnable()
    {
        Disparador.action.performed += Disparador_Presionado;
        Disparador.action.canceled += Disparador_Liberado;

        Agarre.action.performed += Agarre_Presionado;
        Agarre.action.canceled += Agarre_Liberado;

        BotonEje2D.action.performed += BotonEje2D_Presionado; 
        BotonEje2D.action.canceled += BotonEje2D_Liberado;
    }

    private void OnDisable()
    {
        Disparador.action.performed -= Disparador_Presionado;
        Disparador.action.canceled -= Disparador_Liberado;

        Agarre.action.performed -= Agarre_Presionado;
        Agarre.action.canceled -= Agarre_Liberado;

        BotonEje2D.action.performed -= BotonEje2D_Presionado;
        BotonEje2D.action.canceled -= BotonEje2D_Liberado;
    }
}
