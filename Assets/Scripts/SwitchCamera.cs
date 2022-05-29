
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using Cinemachine;

public class SwitchCamera : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera followCamera;
    [SerializeField] Text ranking;

    private Text cameraMode;

    void Awake()
    {
        cameraMode = this.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
    
    }
   public void changeCameraMode()
    {
        bool is1person = cameraMode.text == "1";

        Cinemachine3rdPersonFollow composer = followCamera.GetCinemachineComponent<Cinemachine3rdPersonFollow>();
        composer.CameraDistance = is1person ? 4 : 0;
        cameraMode.text = is1person ? "1" : "3";

    }
}
