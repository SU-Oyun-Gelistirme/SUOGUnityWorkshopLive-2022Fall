using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Collider2D thisCollider;
    public GameObject spawnObject;


    private void Start()
    {
        thisCollider = gameObject.GetComponent<Collider2D>();
    }

    private void Update()
    {
        var pos = GetPosition();
        Spawn(pos);
    }

    private void Spawn(Vector2 spawnPos)
    {
        Instantiate(spawnObject, spawnPos, spawnObject.transform.rotation);
    }

    private Vector2 GetPosition()
    {
        var maxX = thisCollider.bounds.max.x;//colliderin max ve min, x ve y degerlerini al
        var minX = thisCollider.bounds.min.x;
        var maxY = thisCollider.bounds.max.y;
        var minY = thisCollider.bounds.min.y;

        var posx = Random.Range(minX, maxX);//max ve min degerlerini kullanarak rastgele bir deger ver
        var posy = Random.Range(minY, maxY);

        return new Vector2(posx, posy);//rastgele degerleri kullanarak, koordinat duzleminde bir pozisyon olustur
    }

}
