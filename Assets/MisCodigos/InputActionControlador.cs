using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputActionControlador : MonoBehaviour
{
    public InputActionReference AccionPrimaria;
    private void AccionPrimaria_Prionada(InputAction.CallbackContext context)
    {
        print("Accion primaria ejecutada");
    }
    private void AccionPrimaria_Liberada(InputAction.CallbackContext context)
    {
        print("Accion primaria cancelada");
    }
    private void OnEnable()
    {
        AccionPrimaria.action.performed += AccionPrimaria_Prionada;
        AccionPrimaria.action.canceled += AccionPrimaria_Liberada;
    }

    private void OnDisable()
    {
        AccionPrimaria.action.performed -= AccionPrimaria_Prionada;
        AccionPrimaria.action.canceled -= AccionPrimaria_Liberada;
    }

}
