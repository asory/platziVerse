using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFloor : MonoBehaviour
{


    [SerializeField] string playerTag = "Player";
    [SerializeField] float disappearTime = 3;
    [SerializeField] bool canReset;
    [SerializeField] float restTime;
    //[SerializeField] GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

       
    }
    private void OnTriggerEnter(Collider other)
    {


        if (other.transform.tag == playerTag)
        {
            print("OnTriggerEnter");

            print(other.transform.tag);
            Invoke("ShowHideFloor", disappearTime);

        }
    }

    public void ShowHideFloor()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

}
