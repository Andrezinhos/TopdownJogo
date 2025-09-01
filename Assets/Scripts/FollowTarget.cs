using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    Vector3 offset = new Vector3(0, 0, -10);
    public float suav = 5;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("Player").transform;
        }    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 novaPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, novaPos, suav * Time.deltaTime);
    }
}
