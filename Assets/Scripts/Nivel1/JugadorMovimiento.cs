using UnityEngine;
using UnityEngine.InputSystem;

public class JugadorMovimiento : MonoBehaviour
{
    public float velocidad = 5f;

    private Rigidbody2D rb;
    private Vector2 movimiento;
    private ControlesJugador controles;
    private Animator animator;

    void Awake()
    {
        controles = new ControlesJugador();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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

        animator.SetFloat("MoveX", movimiento.x);
        animator.SetFloat("MoveY", movimiento.y);
        animator.SetFloat("Speed", movimiento.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movimiento * velocidad * Time.fixedDeltaTime);
    }
}
