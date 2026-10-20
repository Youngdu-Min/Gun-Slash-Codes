using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    [SerializeField]
    float xMin;
    [SerializeField]
    float xMax;
    [SerializeField]
    GameObject[] weaponList;
    [SerializeField]
    float spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(spawnTime);

        float xPos = Random.Range(xMin, xMax);
        int idx = Random.Range(0, weaponList.Length);
        Instantiate(weaponList[idx], new Vector3(xPos, 46, 1.922888f), Quaternion.identity);

        StartCoroutine(Spawn());

    }
}
