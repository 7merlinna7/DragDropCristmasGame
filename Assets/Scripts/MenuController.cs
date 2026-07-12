using Cinemachine;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject _menueDropList;
    [SerializeField] private List<CinemachineVirtualCamera> _cameras;

    private bool _isActive = false;

    private void Awake()
    {
       _menueDropList.SetActive(_isActive); 
    }

    public void SwitchMenuState()
    {
        _isActive = !(_isActive);
        _menueDropList.SetActive(_isActive);
    }

    public void SwitchCamera(int currentCamera)
    {
        foreach (CinemachineVirtualCamera camera in _cameras)
        {
            if (camera == _cameras[currentCamera])
                camera.Priority = 1;
            else
                camera.Priority = 0;
        }
    }

}
