using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento del objeto
    public float rotateSpeed = 100f; // Velocidad de rotación del objeto

    void Update()
    {
        // Obtiene los valores de entrada horizontal y vertical (AWSD)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calcula el vector de movimiento solo si se usan las teclas AWSD
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            movement += transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement -= transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement -= transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement += transform.right;
        }
        movement = movement.normalized * speed * Time.deltaTime;

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
