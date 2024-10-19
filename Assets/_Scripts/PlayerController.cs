using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    public void Move(Vector2 dir)
    {
        Vector2 dp_2d = dir * Time.deltaTime * speed;
        Vector3 dp = new Vector3(dp_2d.x, dp_2d.y);
        this.transform.position += dp;
    }
}
