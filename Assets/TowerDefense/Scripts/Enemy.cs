using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.right * 2 * Time.deltaTime;
    }
}
