using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImage))]
public class FaceUser : MonoBehaviour
{
    private ARTrackedImage arTrackedImage;
    private Camera mainCamera;

    void Start()
    {
        arTrackedImage = GetComponent<ARTrackedImage>();
        mainCamera = Camera.main;

        if (arTrackedImage == null)
        {
            Debug.LogError("ARTrackedImage component not found.");
            enabled = false;
        }
        else if (mainCamera == null)
        {
            Debug.LogError("Main Camera not found.");
            enabled = false;
        }
    }

    void Update()
    {
        if (arTrackedImage.trackingState == UnityEngine.XR.ARSubsystems.TrackingState.Tracking)
        {
            // 计算相对于摄像头的旋转
            Vector3 directionToCamera = mainCamera.transform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(directionToCamera);

            // 应用旋转
            transform.rotation = targetRotation;
        }
    }
}

