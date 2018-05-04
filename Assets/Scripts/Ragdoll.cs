using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRandomPosition()
    {
        float radius = GameController.Instance.Diameter / 2;
        Vector2 ragdollPos = Random.insideUnitCircle * radius;

        float stretch = GameController.Instance.Stretch;
        stretch = stretch <= 1 ? stretch : 1;

        float x = ragdollPos.x * stretch + GameController.Instance.Bottom.transform.position.x;
        float y = GameController.Instance.Top.transform.position.y;
        float z = ragdollPos.y * stretch + GameController.Instance.Bottom.transform.position.z;
        transform.position = new Vector3(x, y, z);
    }
}