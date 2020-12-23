using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;

    void Start()
    {
        StartCoroutine (Spawn ());
        
    }

    IEnumerator Spawn ()
    {
        
        while (!Player.lose)
        {
            Instantiate (bomb, new Vector2 (Random.Range (-1.7f, 1.7f), 5.9f), Quaternion.identity);
            yield return new WaitForSeconds (0.7f);
        }
    }

   
}
