
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [SerializeField]
    private float fallSpeed;

    void Start()
    {
        fallSpeed = (Random.Range(1f, 10f));
    }

    void Update()
    {
        if (transform.position.y < -5.7)
        {
            Destroy (gameObject);
        }
       
        transform.position -= new Vector3 (0, fallSpeed * Time.deltaTime, 0);
    }
}
