using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
    public GameObject bulletPrefab;

    float moveSpeed = 1.875f;

    [SyncVar]
    public Color color;

    void Update()
    {
        if (isLocalPlayer)
        {
            GetInput();
        }
    }

    void GetInput()
    {
        float x = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;

        if (Input.GetButtonUp("Fire1"))
        {
            CmdDoFire();
        }

        if (isServer)
        {
            RpcMoveIt(x, y);
        }
        else
        {
            CmdMoveIt(x, y);
        }
    }

    [Command]
    public void CmdDoFire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, this.transform.position + this.transform.right, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * 17.5f;
        bullet.GetComponent<Bullet>().color = color;
        Destroy(bullet, 0.875f);
        NetworkServer.Spawn(bullet);
    }

    [ClientRpc]
    void RpcMoveIt(float x, float y)
    {
        transform.Translate(x, y, 0);
    }

    [Command]
    public void CmdMoveIt(float x, float y)
    {
        RpcMoveIt(x, y);
    }

    public override void OnStartClient()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}
