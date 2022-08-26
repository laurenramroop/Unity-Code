using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo) {
        Debug.Log(collisionInfo.GetComponent<Collider> ());
        if (collisionInfo.GetComponent<Collider>().name == "Obstacle") {
            Debug.Log("We hit an obstacle!");
        }
    }
}
