using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float bottomY = -6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            if (CompareTag("Fruit"))
            {
                GameManager.instance.LoseLife();
            }
            Destroy(gameObject);
        }
    }
}
