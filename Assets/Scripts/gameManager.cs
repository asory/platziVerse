
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] CinemachineVirtualCamera followCamera;
    [SerializeField] Text ranking;
    [SerializeField] Button cameraBtn;

    private Text cameraMode;

    public static GameManager sharedInstance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

}
