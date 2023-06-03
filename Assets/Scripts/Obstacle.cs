using System.Collections;
using System.Collections.Generic;
// using UnityEngine;

// public class Obstacle : MonoBehaviour
// {
//     PlayerMovement playerMovement;
//     // Start is called before the first frame update
//     private  void Start()
//     {
//         playerMovement = GameObject.FindObjectOfType <PlayerMovement>();
//     }

//     private void OnCollisionEnter(Collision collision){
//         if(collision.gameObject.name == "Remy@Fast Run"){
//             playerMovement.Die();
//         }
//     }
//     // Update is called once per frame
//     void Update()
//     {
//     }
// }



using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Remy@Fast Run"))
        {
            // Get the PlayerMovement component from the player object
            PlayerMovement playerMovement = other.GetComponent<PlayerMovement>();

            if (playerMovement != null)
            {
                // Call the Die function of the PlayerMovement script
                playerMovement.Die();
            }
        }
    }
}
