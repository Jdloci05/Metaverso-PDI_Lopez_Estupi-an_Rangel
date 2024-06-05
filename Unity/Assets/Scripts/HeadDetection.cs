using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Xennial.XR.UI;

public class HeadDetection : MonoBehaviour
{
    [Header("Threshold")]
    [Tooltip("Dot product threshold for activation")]
    [SerializeField]
    private float _activationThreshold = 0.7f;
    [Tooltip("Dot product threshold for deactivation")]
    [SerializeField]
    private float _deactivationThreshold = 0.6f;

    [SerializeField]
    private TabletBase _tabletBase;
    [SerializeField]
    private RadialIndicatorManager _loading;

    private bool _isLoading = false;
    private bool _isHandOut = true;

    private void Update()
    {
        CheckHandOrientation(transform);
    }

    private void CheckHandOrientation(Transform handTransform)
    {
        Vector3 directionToHead = (Camera.main.transform.position - handTransform.position).normalized;
        Vector3 handPalmForward = -handTransform.up;

        float dotProduct = Vector3.Dot(handPalmForward, directionToHead);

        if (dotProduct > _activationThreshold && !_isLoading && _isHandOut)
        {
            _isLoading = true;
            _isHandOut = false;
            HandleHandDetection();
        }
        else if (dotProduct < _deactivationThreshold && _isLoading)
        {
            _isLoading = false;
            _isHandOut = true;
            _loading.InterruptCountdown();
        }
    }

    private void HandleHandDetection()
    {
        _tabletBase.OpenTabletByHand(transform, false);
        _loading.StartCountdown(transform);
    }
}
