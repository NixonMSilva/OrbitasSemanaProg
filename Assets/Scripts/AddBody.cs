using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddBody : MonoBehaviour
{
    [SerializeField] private SystemLimiter _endGameSystemLimiter;

    [SerializeField] private GameObject _planetoidTemplate;
    [SerializeField] private GameObject _gasGiantTemplate;
    [SerializeField] private GameObject _terrestrialTemplate;
    [SerializeField] private GameObject _starTemplate;
    [SerializeField] private GameObject _blackHoleTemplate;

    [SerializeField] private GameObject _limiterCircle;

    private GameObject _selectedTemplate;

    public void AddPlanetoid ()
    {
        // Seleciona o template de planetoide para adicionar
        _selectedTemplate = _planetoidTemplate;
        Debug.Log("Planetoid");
    }

    public void AddGasGiant ()
    {
        // Seleciona o template de gigante gasoso para adicionar
        _selectedTemplate = _gasGiantTemplate;
        Debug.Log("Gas Giant");
    }

    public void AddTerrestrial ()
    {
        // Seleciona o template de planeta terrestrial para adicionar
        _selectedTemplate = _terrestrialTemplate;
        Debug.Log("Terrestrial");
    }

    public void AddStar ()
    {
        // Seleciona o template de estrela para adicionar
        _selectedTemplate = _starTemplate;
        Debug.Log("Star");
    }

    public void AddBlackHole ()
    {
        // Seleciona o template de buraco negro para adicionar
        _selectedTemplate = _blackHoleTemplate;
        Debug.Log("Black hole");
    }

    private void Start ()
    {
    }
}
