using UnityEditor.ShaderGraph;
using UnityEngine;
using UnityEngine.UIElements;

public class platformOpEnAF : MonoBehaviour
{
    private float timer = 0;
    public float spawnRate = 2;
    public bool uit = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (uit)
            {
                this.gameObject.SetActive(true);
                uit = false;
            }
            else
            {
                this.gameObject.SetActive(false);
                uit = true;
            }
                timer = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
