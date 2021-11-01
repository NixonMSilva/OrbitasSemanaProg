using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<CelestialBody> bodies;
    
    public int bodiesCount = 0;

    public int highScore = 0;

    public float modifier;
    
    public float limitDistance = 20f;

    [SerializeField] public CinemachineVirtualCamera vCam;
    
    [SerializeField] private Score _score;

    [SerializeField] private MenuController _menu;

    private void Awake ()
    {
        // Cria a instância de singleton
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            // Caso já exista, destrua a duplicata
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);

        // Salva em cache a referência ao componente do score
        
        // Salva em cache a referência ao menu
    }

    
    public CelestialBody GetFirstBody ()
    {
        // Retorna o primeiro corpo
        return bodies[0];
    }

    public void ClearBodies ()
    {
        // Deleta os objetos na cena
        
        // Limpa os dados dos corpos na cena

    }

    public void KillGame ()
    {
        // Chama o menu ao terminar o jogo
        
        
        // Atualiza o high score caso o score do último
        // jogo tenha sido maior
       
    }

    public void ResetScore ()
    {
		// Reinicia o valor do score para 0
    }
}
