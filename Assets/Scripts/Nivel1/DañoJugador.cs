using UnityEngine;

public class DañoJugador : MonoBehaviour
{
    public int daño = 1;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerStats.vidas -= daño;
            Debug.Log("Jugador recibió daño. Vidas restantes: " + PlayerStats.vidas);

            if (PlayerStats.vidas <= 0)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        Debug.Log("GAME OVER");
    }
}