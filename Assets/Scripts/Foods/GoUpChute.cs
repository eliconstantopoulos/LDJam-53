using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUpChute : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        Rigidbody2D otherRigidbody = other.gameObject.GetComponent<Rigidbody2D>();
        Food food = other.gameObject.GetComponent<Food>();
        if (food != null){
            if (food.hasEnteredStomach){
                //shoot the food up
                Debug.Log("d");
                otherRigidbody.velocity = new Vector3(otherRigidbody.velocity.x, 30f);
                Debug.Log(otherRigidbody.velocity);
                //otherRigidbody.AddForce(new Vector3(0, 30f));

            }
        }else{
            //shoot the poop up
            otherRigidbody.velocity = new Vector3(otherRigidbody.velocity.x, 30f);
        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        Rigidbody2D otherRigidbody = other.gameObject.GetComponent<Rigidbody2D>();
        Food food = other.gameObject.GetComponent<Food>();
        if (food != null)
        {
            if (food.hasEnteredStomach)
            {
                //shoot the food up
                otherRigidbody.velocity = new Vector3(otherRigidbody.velocity.x, 30f);
                Debug.Log(otherRigidbody.velocity);
                //otherRigidbody.AddForce(new Vector3(0, 30f));

            }
        }else{
            otherRigidbody.velocity = new Vector3(otherRigidbody.velocity.x, 30f);
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        Debug.Log("exit");
        Food food = other.gameObject.GetComponent<Food>();
        if (food != null){
            food.hasEnteredStomach = true;
        }

    }
}