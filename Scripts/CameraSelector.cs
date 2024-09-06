using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSelector : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera defaultCamera;
    public CinemachineVirtualCamera DefaultCamera => defaultCamera;
    static CinemachineVirtualCamera[] cameras => FindObjectsByType<CinemachineVirtualCamera>(FindObjectsSortMode.None);

    public CinemachineVirtualCamera CameraInUse => cameraInUse;
    CinemachineVirtualCamera cameraInUse;

    private void Awake()
    {
        SelectDefaultCamera();

    }

    public void SelectCamera(CinemachineVirtualCamera selectedCamera)
    {
        foreach (var camera in cameras)
        {
            camera.enabled = false;
        }

        selectedCamera.enabled = true;
        cameraInUse = selectedCamera;
    }

    public void SelectDefaultCamera()
    {
        SelectCamera(defaultCamera);
    }

}
