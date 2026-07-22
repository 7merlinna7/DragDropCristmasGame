using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const int _leftMouseButton = 0;
    private const int _rightMouseButton = 1;

    [SerializeField] private float _explotionRadius;
    [SerializeField] private ExplotionEffect _explotionEffect;

    private DragRayShooter _dragRayShooter;
    private ExplosionRayShooter _explosionRayShooter;

    private void Awake()
    {
        _dragRayShooter = new DragRayShooter();
        _explosionRayShooter = new ExplosionRayShooter(_explotionRadius,_explotionEffect);
    }

    private void Update()
    {
        if (Input.GetMouseButton(_leftMouseButton))
        {
            _dragRayShooter.Shoot();
        }

        if (Input.GetMouseButtonUp(_leftMouseButton))
        {
            _dragRayShooter.StopDraging();
        }

        if (Input.GetMouseButtonDown(_rightMouseButton))
        {
            _explosionRayShooter.Shoot();
        }
    }
}
