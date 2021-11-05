using UnityEngine;

public class SpeedUpItem : MonoBehaviour
{
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && !other.isTrigger)
        {
            var playerMovement = player.GetComponent<PlayerMovement>();
            playerMovement.TakeMovementSpeed();

            gameObject.SetActive(false);
        }
    }
}
