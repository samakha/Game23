using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SpawnEnemy : MonoBehaviour
{
    public float spawnRange = 4f;
    public GameObject enemies;
    void Start()
    {
        StartCoroutine(SpawnE());
    }

    // Update is called once per frame
    void Update()
    {




    }

    IEnumerator SpawnE()
    {
        Vector2 spawnPos = GameObject.Find("Player").transform.position;

        spawnPos += Random.insideUnitCircle.normalized * spawnRange;

        Instantiate(enemies, spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        StartCoroutine(SpawnE());
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void preLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
