using UnityEngine;

public class PlasmaVial : MonoBehaviour
{
    public GameObject explosionEffectPrefab;  // Drag your explosion prefab here

    private void OnCollisionEnter(Collision collision)
    {
        // Optional: only react to bullets
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Explode();
        }
    }

    void Explode()
    {
        // Instantiate explosion prefab at the vial’s position and default rotation
        Instantiate(explosionEffectPrefab, transform.position, Quaternion.identity);

        // Destroy the vial GameObject so it disappears
        Destroy(gameObject);
    }
}
