using System;
using UnityEngine;

public class DragRayShooter : IRayShooter
{
    private Plane plane = new Plane(Vector3.down, 0);
    private bool _isDraged;
    private IDragged _dragged;


    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (_isDraged == false)
        {
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                _dragged = hit.collider.GetComponent<IDragged>();

                if (_dragged != null)
                {
                    _isDraged = true;
                }
            }
        }

        if (_isDraged && (_dragged != null))
        {
            if (plane.Raycast(ray, out float distance))
            {
                _dragged.Drag(ray.GetPoint(distance));
            }
        }
    }

    public void StopDraging() => _isDraged = false;
}
