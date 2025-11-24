using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float tiempoInvulnerable = 1f;
    private bool invulnerable = false;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy") && !invulnerable)
        {
            TomarDaño(1);
        }
    }

    void TomarDaño(int cantidad)
    {
        PlayerStats.vidas -= cantidad;
        Debug.Log("Daño recibido. Vidas actuales: " + PlayerStats.vidas);

        invulnerable = true;
        Invoke(nameof(ResetInvulnerabilidad), tiempoInvulnerable);

        if (PlayerStats.vidas <= 0)
        {
            GameOver();
        }
    }

    void ResetInvulnerabilidad()
    {
        invulnerable = false;
    }

    void GameOver()
    {
        Debug.Log("GAME OVER - Cambiar a escena de derrota después");
    }
}
