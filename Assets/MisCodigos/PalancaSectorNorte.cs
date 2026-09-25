using UnityEngine;
using UnityEngine.InputSystem;

public class PalancaSectorNorte : MonoBehaviour
{
    [SerializeField]
    private InputActionReference palancaNorte;

    //[SerializeField]
   // private float umbral = 0.5f;

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

        //if (valor.y > umbral)
        //{
            Debug.Log(valor);
        //}
    }
}
