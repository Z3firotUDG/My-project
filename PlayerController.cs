using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float velocidadX = Input.GetAxis("Horizontal")*Time.deltaTime*velocidad;

        Vector3 posicion = transform.position;

        transform.position = new vector3 (velocidadX + posicion.x, posicion.y, posicion.z); 
 
    }
}
