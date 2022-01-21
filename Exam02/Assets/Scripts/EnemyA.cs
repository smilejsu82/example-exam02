using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    public float speed = 2.0f;
    private float delta;
    public GameObject enemyABulletPrefab;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > 1.0f) {
            this.delta = 0;

            //ÃÑ¾Ë ¹ß»ç 
            var bulletGo = Instantiate<GameObject>(this.enemyABulletPrefab);
            bulletGo.transform.position = this.firePoint.position;
        }

        var dir = Vector2.down;
        this.transform.Translate(dir * this.speed * Time.deltaTime);
        if (this.transform.position.y <= -5.37f) {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("PlayerBullet"))
        {
            Destroy(this.gameObject);
        }
    }
}
