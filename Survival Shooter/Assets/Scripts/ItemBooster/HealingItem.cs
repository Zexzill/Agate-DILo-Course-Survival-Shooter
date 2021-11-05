using UnityEngine;

public class HealingItem : MonoBehaviour
{
    private GameObject player;
    public int healAmount = 10;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && !other.isTrigger)
        {
            var playerHealth = player.GetComponent<PlayerHealth>();
            playerHealth.TakeHeal(healAmount);

            gameObject.SetActive(false);
        }
    }
}
