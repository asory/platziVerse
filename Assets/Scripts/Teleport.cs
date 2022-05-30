using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{

    [SerializeField] string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == playerTag)
        {
            SceneManager.LoadScene(2);
        }
    }
}
