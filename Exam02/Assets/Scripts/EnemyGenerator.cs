using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    private float delta;
    public GameObject enemyAPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > 1.0f) {
            this.delta = 0;

            GameObject enemyAGo =  Instantiate<GameObject>(this.enemyAPrefab);
            //https://docs.unity3d.com/ScriptReference/Random.Range.html
            float randx = Random.Range(-2, 2);
            float posy = 5.76f;
            enemyAGo.transform.position = new Vector3(randx, posy, 0);

        }
    }
}
