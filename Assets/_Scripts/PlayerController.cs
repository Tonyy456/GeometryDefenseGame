using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.transform.position += new Vector3(0, 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
