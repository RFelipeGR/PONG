using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float velocidadJugador;

    private Rigidbody2D rb;
    private Vector2 direccionJugador;
    private Vector2 direccionJugador2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float direccionY = Input.GetAxisRaw("Vertical");
        float direccionY2 = Input.GetAxisRaw("Player2Vertical");
        direccionJugador = new Vector2(0, direccionY).normalized;
        direccionJugador2 = new Vector2(0, direccionY2).normalized;
    }

    void FixedUpdate()
    {
        if (gameObject.tag == "Raqueta")
        {
            rb.linearVelocity = direccionJugador * velocidadJugador;
        }

        if (gameObject.tag == "Raqueta2")
        {
            rb.linearVelocity = direccionJugador2 * velocidadJugador;
        }
    }
}