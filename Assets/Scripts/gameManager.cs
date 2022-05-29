
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] CinemachineVirtualCamera followCamera;
    [SerializeField] Text ranking;

    [SerializeField]  PlayerScore scoreScript;

    public static GameManager sharedInstance;

}
