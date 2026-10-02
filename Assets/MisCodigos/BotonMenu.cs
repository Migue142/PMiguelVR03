using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BotonMenu : MonoBehaviour
{
    public InputActionReference AccionPrimaria;
    public InputActionReference Boton_Menu;
    public InputActionReference AccionSecundaria;

    private void Boton_Menu_Presionada(InputAction.CallbackContext context)
    {
        print("Boton Menu ejecutada");
    }
    private void Boton_Menu_Liberada(InputAction.CallbackContext context)
    {
        print("Boton Menu cancelada");
    }
    private void AccionPrimaria_Prionada(InputAction.CallbackContext context)
    {
        print("Accion primaria ejecutada");
    }
    private void AccionPrimaria_Liberada(InputAction.CallbackContext context)
    {
        print("Accion primaria cancelada");
    }
    private void AccionSecundaria_Presionada(InputAction.CallbackContext context) 
    { 
        print("Accion secundaria ejecutada"); 
    }
    private void AccionSecundaria_Liberada(InputAction.CallbackContext context)
    {
        print("Accion secundaria cancelada");
    }
    private void OnEnable()
    {
        AccionPrimaria.action.performed += AccionPrimaria_Prionada;
        AccionPrimaria.action.canceled += AccionPrimaria_Liberada;
        
        Boton_Menu.action.performed += Boton_Menu_Presionada;
        Boton_Menu.action.canceled += Boton_Menu_Liberada;
        
        AccionSecundaria.action.performed += AccionSecundaria_Presionada; 
        AccionSecundaria.action.canceled += AccionSecundaria_Liberada;
    }

    private void OnDisable()
    {
        AccionPrimaria.action.performed -= AccionPrimaria_Prionada;
        AccionPrimaria.action.canceled -= AccionPrimaria_Liberada;
        
        Boton_Menu.action.performed -= Boton_Menu_Presionada;
        Boton_Menu.action.canceled -= Boton_Menu_Liberada;
        
        AccionSecundaria.action.performed -= AccionSecundaria_Presionada;
        AccionSecundaria.action.canceled -= AccionSecundaria_Liberada;
    }


}
