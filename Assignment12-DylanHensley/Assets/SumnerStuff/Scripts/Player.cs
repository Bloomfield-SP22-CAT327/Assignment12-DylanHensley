using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Player : NetworkBehaviour
{
    public GameObject bulletPrefab;

    float moveSpeed = 1.875f;

    [SyncVar]
    public int score;

    [SyncVar]
    public Color color;

    public const int MaxHealth = 100;

    [SyncVar]
    public int health = 100;

    private Text scoreText;

    public override void OnStartClient()
    {
        gameObject.GetComponent<Renderer>().material.color = color;
        transform.Find("Canvas").GetComponent<Canvas>()
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    void Update()
    {
        if (isLocalPlayer && hasAuthority)
        {
            GetInput();
            scoreText.text = "Score: " + score;
        }

        if (Input.GetKeyDown(KeyCode.Minus))
        {
            health--;
        }

        transform.Find("Canvas").Find("HealthBar").Find("Fill").gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.transform.gameObject.
            transform.gameObject.transform.gameObject.transform.gameObject.GetComponent<Image>().fillAmount = (this.health / MaxHealth);
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
        bullet.GetComponent<Bullet>().parentNetId = this.netId;
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
}
