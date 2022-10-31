using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject shootPos;
    public GameObject bullet;

    private float lastBulletTime;

    public float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        lastBulletTime = -999;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)   &&   lastBulletTime+cooldown <= Time.time)
        {
            lastBulletTime = Time.time;
            GameObject spawnObject = Instantiate(bullet, shootPos.transform.position, shootPos.transform.rotation);
        }
    }
}
