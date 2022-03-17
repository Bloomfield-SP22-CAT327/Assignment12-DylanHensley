using UnityEngine;
using Mirror;

public class Player : NetworkBehaviour
{
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

        if (isServer)
        {
            RpcMoveIt(x, y);
        }
        else
        {
            CmdMoveIt(x, y);
        }
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
