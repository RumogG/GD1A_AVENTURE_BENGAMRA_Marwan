using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private void Awake()
    {
        GameObject perso = GameObject.FindWithTag("Perso");
        perso.transform.position = gameObject.transform.position;
    }
}