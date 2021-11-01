using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuPanel;
    [SerializeField] private GameObject _highScoreValue;
    [SerializeField] private GameObject _gameButtons;
    [SerializeField] private GameObject _scorePanel;

    public void StartGame ()
    {
        // Esconde o painel do menu
        _mainMenuPanel.SetActive(false);
        
        // Exibe os botões do jogo
        _gameButtons.SetActive(true);
        
        // Exibe o painel do placar
        _scorePanel.SetActive(true);

        // Limpa os corpos celestes da cena
        GameManager.instance.ClearBodies();

        // Reinicia o placar
        GameManager.instance.ResetScore();
        
        // Ativa a simulação
        Time.timeScale = 1f;
    }

    public void EndGame ()
    {
        // Mostra o painel do menu
        _mainMenuPanel.SetActive(true);
        
        // Esconde os botões do jogo
        _gameButtons.SetActive(false);
        
        // Esconde o painel do placar
        _scorePanel.SetActive(false);
        
        // Congela o tempo (pausa a simulação)
        Time.timeScale = 0f;
    }

    public void ExitGame ()
    {
        // Sai da aplicação para o desktop
        Application.Quit();
    }

    public void UpdateHighScore (int newScore)
    {
        // Pega o component de texto do objeto na cena
        Text highScoreText = _highScoreValue.GetComponent<Text>();
        
        // Atualiza o valor desse texto com o novo high score
        highScoreText.text = newScore.ToString();
    }
}
