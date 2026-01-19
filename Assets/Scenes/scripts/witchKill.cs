using UnityEngine;

public class witchKill : MonoBehaviour
{
    public GameObject witch;
    public float spawnRate = 100000000000000000;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnWitch();
            timer = 0;
        }
    }

    void spawnWitch()
    {
        Instantiate(witch);
    }
}
