using UnityEngine;
using UnityEngine.InputSystem;

public class JugadorMovimiento : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private Vector2 movimiento;
    private ControlesJugador controles;

    void Awake()
    {
        controles = new ControlesJugador();
        rb = GetComponent<Rigidbody2D>();   
    }

    void OnEnable()
    {
        controles.Movimiento.Mover.Enable();
    }

    void OnDisable()
    {
        controles.Movimiento.Mover.Disable();
    }

    void Update()
    {
        movimiento = controles.Movimiento.Mover.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}
