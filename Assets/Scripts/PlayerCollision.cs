using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    
    public PlayerMovement movement; 

    void OnCollisionEnter(Collision collisionInfo) {
        
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false; //OR GetComponent<PlayerMovement>().enabled = false
            FindObjectOfType<GameManager>().EndGame();
        }
    }

} 