using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawn : MonoBehaviour
{
    [SerializeField] private List<PresentBox> _BoxPrefabs;

    private void Awake()
    {
       SpawnBox(); 
    }

    public void SpawnBox()
    {
        int randomBox = Random.Range(0, _BoxPrefabs.Count);
        Instantiate(_BoxPrefabs[randomBox],transform.position,transform.rotation);
    }


}
