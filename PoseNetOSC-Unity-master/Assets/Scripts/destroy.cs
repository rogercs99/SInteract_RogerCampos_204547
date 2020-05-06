using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
	
	public string tagFilter1;
	public string tagFilter2;
	public uimana manager;



   private void OnTriggerEnter (Collider other) {

		if (other.CompareTag(tagFilter1)){
		 	Destroy(gameObject); 

		}

		if (other.CompareTag(tagFilter2)){
			manager.atom_corta = manager.atom_corta + 1;
		 	Destroy(gameObject); 

		}

 	}
}
