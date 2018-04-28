using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float Distance;
    private GameObject _hipsPos;

    // Use this for initialization
    void Start()
    {
        _hipsPos = GameObject.FindWithTag("Hips");
    }

    // Update is called once per frame
    void Update()
    {
        float x = _hipsPos.transform.position.x;
        float y = _hipsPos.transform.position.y + Distance;
        float z = _hipsPos.transform.position.z - Distance;
        transform.position = new Vector3(x, y, z);
    }
}