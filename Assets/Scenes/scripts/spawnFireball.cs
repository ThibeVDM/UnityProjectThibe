using UnityEngine;

public class spawnFireball : MonoBehaviour
{
    public GameObject fireball;
    public float spawnRate = 2;
    private float timer = 0;
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
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
            Instantiate(fireball, transform.position, transform.rotation);
            timer = 0;
        }
        if (logic.witchIsAlive == false) {
           Destroy(gameObject);
        }
            
    }
}
