using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Vector2.up;
        this.transform.Translate(dir * this.speed * Time.deltaTime);

        if (this.transform.position.y >= 5.41f) {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemy")) {
            Destroy(this.gameObject);
        }
    }
}
