using UnityEngine;
using Mirror;

public class Bullet : NetworkBehaviour
{
    [SyncVar]
    public uint parentNetId;

    [SyncVar]
    public Color color;

    public override void OnStartClient()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }

    void OnTriggerEnter(Collider other)
    {
        if (isServer)
        {
            Player player = NetworkIdentity.spawned[parentNetId].GetComponent<Player>();
            player.score += 100;
            Destroy(other.gameObject);
        }
    }
}