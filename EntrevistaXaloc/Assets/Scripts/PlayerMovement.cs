/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del personaje

    void Update()
    {
        // Obtiene los valores de entrada horizontal y vertical (ASDW, flechas de dirección)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calcula el vector de movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * speed * Time.deltaTime;

        // Mueve el personaje en la dirección del vector de movimiento
        transform.Translate(movement, Space.Self);
    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del objeto
    public float rotateSpeed = 100f; // Velocidad de rotación del objeto

    void Update()
    {
        // Obtiene los valores de entrada horizontal y vertical (ASDW, flechas de dirección)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calcula el vector de movimiento
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * speed * Time.deltaTime;

        // Mueve el objeto en la dirección del vector de movimiento
        transform.Translate(movement, Space.Self);

        // Rota el objeto hacia la izquierda o la derecha al presionar A o D respectivamente
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
