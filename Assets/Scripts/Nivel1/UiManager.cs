using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textoOrbes;
    public TextMeshProUGUI textoVidas;

    void Start()
    {
        if (textoOrbes == null)
            textoOrbes = GameObject.Find("TextoOrbes")?.GetComponent<TextMeshProUGUI>();

        if (textoVidas == null)
            textoVidas = GameObject.Find("TextoVidas")?.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (textoOrbes != null)
            textoOrbes.text = "Orbes: " + PlayerStats.orbes + "/10";
        else
            Debug.LogWarning("UIManager: 'textoOrbes' no asignado.");

        if (textoVidas != null)
            textoVidas.text = "Vidas: " + PlayerStats.vidas;
        else
            Debug.LogWarning("UIManager: 'textoVidas' no asignado.");
    }
}