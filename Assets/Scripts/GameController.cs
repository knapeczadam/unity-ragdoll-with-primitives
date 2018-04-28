using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance = null;
    
    public int Obstacles;
    public float MinSize;
    public float MaxSize;
    public float Stretch; // horizontal
    public int PlaneScale;
    
    public GameObject Bottom;
    public GameObject Top;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start()
    {
        Bottom.transform.localScale = Vector3.one * PlaneScale;
        Top.transform.localScale = Vector3.one * PlaneScale;
        
        CreateObstacles();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void CreateObstacles()
    {
        float radius = Bottom.GetComponent<Renderer>().bounds.size.x / 2;
        
        for (int i = 0; i < Obstacles; i++)
        {
            Vector3 spherePos = Random.insideUnitSphere * radius;
            
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            
            float x = spherePos.x * Stretch;
            float y = spherePos.y + Mathf.Abs((Bottom.transform.position.y - Top.transform.position.y) / 2);
            float z = spherePos.z * Stretch;
            
            sphere.transform.position = new Vector3(x, y, z);
            sphere.transform.localScale = Vector3.one * Random.Range(MinSize, MaxSize);
            sphere.GetComponent<Renderer>().material.color =  Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }
}