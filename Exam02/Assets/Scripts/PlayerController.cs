using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;
    public GameObject bulletPrefab;
    public Transform firePoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            var dir = Vector2.left;
            this.transform.Translate(dir.x * this.speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow)) 
        {
            var dir = Vector2.right;
            this.transform.Translate(dir.x * this.speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            //√—æÀ «¡∏Æ∆’ ¿ŒΩ∫≈œΩ∫»≠ 
            var bulletGo = Instantiate<GameObject>(this.bulletPrefab);
            bulletGo.transform.position = this.firePoint.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("EnemyBullet") || collision.tag.Equals("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
