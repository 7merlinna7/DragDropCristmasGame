using UnityEngine;

public class ExplosionRayShooter : IRayShooter
{
    private float _radius;
    private ExplotionEffect _explotionEffect;

    public ExplosionRayShooter(float radius,ExplotionEffect explotionEffect)
    {
        _radius = radius;
        _explotionEffect = explotionEffect;
    }

    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            _explotionEffect.CreateEffect(hit.point);
            Collider[] targets = Physics.OverlapSphere(hit.point, _radius);

            foreach (Collider target in targets)
            {
                IExplosive explosive = target.GetComponent<IExplosive>();
                if (explosive != null)
                    explosive.Explode(hit.point, _radius);
            }
        }
    }
}
