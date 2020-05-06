using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atom_move : MonoBehaviour
{

	public Vector3 movementSpeed; //1
	public Space space; //2
	private atomspawner atomSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	transform.Rotate(0, 50 * Time.deltaTime , 0);
        transform.Translate(movementSpeed * Time.deltaTime, space);
    }

    public void SetSpawner(atomspawner spawner)
	{
	    atomSpawner = spawner;
	}



}
