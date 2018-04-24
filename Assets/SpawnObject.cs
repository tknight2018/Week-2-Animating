using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject WallPrefab;


	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnWall());

	}
	
	// Update is called once per frame
	void Update () {


	}

    IEnumerator SpawnWall()
    {
        Instantiate(WallPrefab, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);

        StartCoroutine(SpawnWall());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(gameObject);
        }


    }





}
