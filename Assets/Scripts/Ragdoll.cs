using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        float radius = GameController.Instance.Bottom.GetComponent<Renderer>().bounds.size.x / 2;
        Vector2 ragdollPos = Random.insideUnitCircle * radius;

        float x = ragdollPos.x * GameController.Instance.Stretch;
        float y = GameController.Instance.Top.transform.position.y;
        float z = ragdollPos.y * GameController.Instance.Stretch;
        transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}