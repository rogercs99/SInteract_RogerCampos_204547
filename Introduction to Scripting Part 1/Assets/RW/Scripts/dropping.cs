using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropping : MonoBehaviour
{

	public float dropDestroyDelay ; // 1
	public Collider myCollider; // 2
	public Rigidbody myRigidbody;
    public string tagFilter;


    // Start is called before the first frame update
    void Start()
    {

    	myCollider = GetComponent<Collider>();
 		myRigidbody = GetComponent<Rigidbody>();
        
    }


   private void OnTriggerEnter (Collider other) {

		if (other.CompareTag(tagFilter)){

		 	Drop();

		}

 	}


    private void Drop()
	{
		 myRigidbody.isKinematic = false; // 1
		 myCollider.isTrigger = false; // 2
		 Destroy(gameObject, dropDestroyDelay); // 3
	}


}
