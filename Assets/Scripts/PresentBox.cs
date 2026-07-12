using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentBox :MonoBehaviour, IDragged,IExplosive
{
    private Rigidbody _rigidbody;
    [SerializeField] private float _explotionForce = 1000f;
    [SerializeField] private float _explodeUpwardsModifier = 0.2f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Drag(Vector3 mousePosition)
    {
        transform.position = mousePosition;
        transform.rotation = Quaternion.identity;
    }

    public void Explode(Vector3 explotionPosition, float explotionRadius)
    {
        _rigidbody.AddExplosionForce(_explotionForce, explotionPosition, explotionRadius,_explodeUpwardsModifier,ForceMode.Impulse);
        
    }
}
