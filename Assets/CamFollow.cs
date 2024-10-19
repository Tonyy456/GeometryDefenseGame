using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CamFollow : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject toFollow;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target = toFollow.gameObject.transform.position;
        Vector2 moveTo = this.transform.position;
        Vector2 p = Vector2.Lerp(target, moveTo, speed);
        this.transform.position = new Vector3(p.x, p.y, this.transform.position.z);
    }
}
