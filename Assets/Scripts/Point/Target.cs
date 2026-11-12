using UnityEngine;

public class Target : MonoBehaviour
{
    public Transform target;
    public float radius = 5f;

    // Update is called once per frame
    void Update()
    {
        if (target == null ) return;

        float distance = Vector2.Distance(transform.position, target.position);
        if (distance <= radius)
        {
            Debug.Log("Пойман");
        } 
    }
}
