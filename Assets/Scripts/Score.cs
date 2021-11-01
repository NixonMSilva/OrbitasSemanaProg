using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private int _bhValue = 20;
    [SerializeField] private int _starValue = 10;
    [SerializeField] private int _tpValue = 3;
    [SerializeField] private int _ggValue = 6;
    [SerializeField] private int _pdValue = 1;

    private int _score = 0;

    [SerializeField] private Text _scoreText;

    public int ScoreValue
    {
        set
        {   
            // Atualiza o valor do placar
            _score = value;
            
            // Atualiza o texto do placar
            _scoreText.text = _score.ToString();
        }
        get => _score;
    }

    // Cálculo do Score é feito no FixedUpdate pois
    // ele acompanha a evolução da simulação com
    // base no motor físico
    private void FixedUpdate ()
    {
        CalculateBodies();
    }

    private void CalculateBodies ()
    {
        // Sem cálculo se a órbita é estável demais (< 3 corpos)
        if (GameManager.instance.bodiesCount < 3)
            return;
        
        // Adiciona no score para cada corpo presente no sistema
        // conforme os seus tipos
        foreach (CelestialBody body in GameManager.instance.bodies)
        {
            switch (body.CelestialBodyType)
            {
                case BodyType.blackHole:
                    ScoreValue += _bhValue;
                    break;
                case BodyType.star:
                    ScoreValue += _starValue;
                    break;
                case BodyType.terrestrial:
                    ScoreValue += _tpValue;
                    break;
                case BodyType.gasGiant:
                    ScoreValue += _ggValue;
                    break;
                case BodyType.planetoid:
                    ScoreValue += _pdValue;
                    break;
                default:
                    break;
            }
        }
    }
}
