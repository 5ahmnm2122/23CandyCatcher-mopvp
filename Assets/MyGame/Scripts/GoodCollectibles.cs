using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodCollectibles : MonoBehaviour
{
    public float collectableSpeed;
    private Rigidbody2D collectableRb2D;
    public gameVariables data;
    public int addScore;
    // Start is called before the first frame update
    void Start()
    {
        collectableRb2D = this.GetComponent<Rigidbody2D>();
        collectableRb2D.velocity = new Vector2(0, -collectableSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered");
        data.score += addScore;
        Debug.Log(data.score);
        Destroy(this.gameObject);
    }


}
