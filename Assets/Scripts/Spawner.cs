
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Game objects to generate
    public Texture[] Badges;
    public GameObject Coin;

    // Time controller
    [SerializeField] float time;
    // Interval between every generation on seconds
    [SerializeField] float interval;
    // Range of dispersion between object on units
    [SerializeField] float dispersionRange;
    // Items random to create
    [SerializeField] public float creationAmount = 3;

    // Game objects position into game
    [SerializeField] float[] horizontalLimits;
    [SerializeField] float[] verticalLimits;
    [SerializeField] float[] zLimits;



    void Start () {
        // building sprite reference position
     

 
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time >= interval) {
            for(int i = 0; i < Random.Range(1, creationAmount); i++) {
                generate();
            }
            time = 0;
        }
        
    }

    // Define inntial position
    Vector3 getRandomPosition(){
        float randomX = Random.Range(-dispersionRange, dispersionRange);
        float randomY = Random.Range(-dispersionRange/2, dispersionRange/2);
        float randomZ = Random.Range(-dispersionRange / 2, dispersionRange / 2);


        Vector3 position = this.transform.position;
        position.x = position.x + randomX;
        position.y = position.y + randomY;
        position.z = position.z + randomZ;


        return position;
    }

    // Method to generate random object around father position 
    void generate() {
        Vector3 position = getRandomPosition();

    
        if(position.x <= horizontalLimits[1] && position.y >= horizontalLimits[0] || position.z >= zLimits[0])
        {
            generate();
            return;
        }

        // Type of potion handler
        Texture newTexture= Badges[Random.Range(0, Badges.Length)];
        GameObject newCoin = Coin;
        Instantiate(newCoin, position, Quaternion.identity);
        newCoin.SetActive(false);

    }
}
