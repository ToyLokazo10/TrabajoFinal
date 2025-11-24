using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string escenaNivel = "Nivel1";
    public string escenaCreditos = "Credits";
    public string escenaSettings = "Settings";
    public string escenaMenu = "SampleScene";

    public void Jugar()
    {
        SceneManager.LoadScene("Nivel1");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}
