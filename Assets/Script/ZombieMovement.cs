

using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Zombie avance tout seul
        transform.Translate(Vector3.forward * 
            moveSpeed * Time.deltaTime);
    }
}
