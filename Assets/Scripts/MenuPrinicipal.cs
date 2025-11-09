using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string escenaNivel = "Nivel1";
    public string escenaCreditos = "Creditos";

    public void Jugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void Creditos()
    {
        SceneManager.LoadScene(escenaCreditos);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("El juego se cerro..");
    }
}
