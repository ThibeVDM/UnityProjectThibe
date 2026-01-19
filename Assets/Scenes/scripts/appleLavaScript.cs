using UnityEngine;

public class appleLavaScript : MonoBehaviour
{
    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.flameIsAlive == false)
        {
            Destroy(gameObject);
        }
    }
}
