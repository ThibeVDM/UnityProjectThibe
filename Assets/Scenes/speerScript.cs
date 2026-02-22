using UnityEngine;

public class SpeerScript : MonoBehaviour
{
    public float speed = 5f;

    
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        // Alleen bewegen zolang we niets geraakt hebben
        
        if (!(transform.position.y > 35.61) && logic.speerOmhoog)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (transform.position.y > 35.61) {
            logic.deadEyesOn();
            logic.trampolineVisible();
        }

    }

    

    private System.Collections.IEnumerator DestroyAfterSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
