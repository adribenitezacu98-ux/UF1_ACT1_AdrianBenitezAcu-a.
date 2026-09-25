using UnityEngine;
using UnityEngine.UI;

public class Script_Interfaz : MonoBehaviour
{
    [SerializeField] private Script_Vida sistemaVida;
    [SerializeField] private Slider barra;
    [SerializeField] public Button BotonRevivir;
    [SerializeField] public Button BotonMorir;
    [SerializeField] public Button BotonCurar;
    [SerializeField] public Button BotonDaño;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        barra.maxValue = Script_Vida.MAXHP;

        
    }

    // Update is called once per frame
    void Update()
    {
        barra.value = sistemaVida.vida;

        ActualizarBotones();
        
    }

    public void ActualizarBotones()
    {
        BotonMorir.interactable = sistemaVida.vivo;
        BotonRevivir.interactable = !sistemaVida.vivo;

        if (sistemaVida.vida == Script_Vida.MAXHP || sistemaVida.vida == Script_Vida.MINHP)
        {
            BotonCurar.interactable = false;
        }else
        {
            BotonCurar.interactable = true;
        }

        if (sistemaVida.vida == Script_Vida.MINHP)
        {
            BotonDaño.interactable = false;
        }else
        {
            BotonDaño.interactable = true;
        }
    }
}

