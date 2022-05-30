using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    [SerializeField] int points=10;


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
            Destroy(gameObject);
            PlayerScore.instance.AddPoints(points);

        }
    }
}
