using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TriggerInteractable))]
public class CameraArea : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] bool applyOnExitInstead;

    TriggerInteractable TriggerInteractable => GetComponent<TriggerInteractable>();
    CameraSelector CameraSelector => FindObjectOfType<CameraSelector>();

    private void Awake()
    {
        if (applyOnExitInstead)
            TriggerInteractable.OnExitAction += Trigger;
        else
            TriggerInteractable.OnEnterAction += Trigger;
    }

    public void Trigger(Interactor interactor)
    {
        CameraSelector.SelectCamera(virtualCamera);
    }

}
