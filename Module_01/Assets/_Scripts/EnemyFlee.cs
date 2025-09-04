using UnityEngine;

public class EnemyFlee : MonoBehaviour
{
    public Transform playerTarget; // Assign player transform in Inspector
    public float fleeSpeed = 5f;

    void Update()
    {
        if (playerTarget != null)
        {
            // Calculate direction *away* from the player
            Vector3 direction = (transform.position - playerTarget.position).normalized;

            // Move the enemy away from the player
            transform.Translate(direction * fleeSpeed * Time.deltaTime, Space.World);

            // Optional: rotate to face away from the player
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}