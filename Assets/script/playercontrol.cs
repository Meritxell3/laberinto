using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
private Rigidbody playerb; //el rb del player
private float speed = 1f; // velocidad
private float speedJump = 15f; // velocidad de salto
private Vector3 moveInput; // inputs de movimiento

    // Start is called before the first frame update
    void Start()
    {
      playerb = GetComponent <Rigidbody>(); // le pedimos el rb
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        moveInput = new Vector3(moveX,0,moveZ);

        if(Input.GetKey("space") && playerb.velocity.y == 0){
            playerb.AddForce(transform.up * speedJump);
            Debug.Log("espacio,aprete espacio");
        }

    }
private void FixedUpdate(){
playerb.MovePosition(playerb.position + moveInput.normalized *speed* Time.fixedDeltaTime);// que el rb mueva la position del player sumandole el movimiento del imput por la velocidad por el tiempo que se ejecuta
}




}
