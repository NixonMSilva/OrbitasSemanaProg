using UnityEngine;

// A ser implementado

public class CelestialBody : MonoBehaviour
{
    [SerializeField] private BodyType _celestialBodyType;

    public BodyType CelestialBodyType
    {
        get => _celestialBodyType;
    }
}
