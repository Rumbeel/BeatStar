using UnityEngine;

public class TestDestroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Тест пройден");
            Destroy(gameObject);
        }        
    }
}
