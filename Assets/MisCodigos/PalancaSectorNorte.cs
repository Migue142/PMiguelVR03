using UnityEngine;
using UnityEngine.InputSystem;
public class PalancaSectorNorte : MonoBehaviour 
{ 
    [SerializeField] 
    private InputActionReference palancaNorte; 
    private void OnEnable() 
    {
        palancaNorte.action.Enable(); 
    } 
    private void OnDisable() 
    { 
        palancaNorte.action.Disable(); 
    } 
    private void Update() 
    { 
        Vector2 valor = palancaNorte.action.ReadValue<Vector2>(); 
        if (valor.y > 0.5f) 
        { Debug.Log("Norte: " + valor); } 
        else if (valor.y < -0.5f) 
        { 
            Debug.Log("Sur: " + valor); 
        } else if (valor.x > 0.5f) 
        { 
            Debug.Log("Este: " + valor); 
        } else if (valor.x < -0.5f) 
        { 
            Debug.Log("Oeste: " + valor); 
        } 
    } 
}
