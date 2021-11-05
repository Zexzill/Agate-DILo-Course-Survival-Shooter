using UnityEngine;

public class BoosterFactory : MonoBehaviour, IBooster
{
    [SerializeField] GameObject[] itemPrefabs;

    public void BoosterMethod(int index)
    {
        Instantiate(itemPrefabs[index]);
    }
}
