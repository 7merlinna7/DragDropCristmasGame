using UnityEngine;

public class ExplotionEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem _explotionEffect;

    public void CreateEffect(Vector3 position)
    {
        Instantiate(_explotionEffect,position,Quaternion.identity);
    }
}
