using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atomspawner : MonoBehaviour
{
	public bool canSpawn = true; // 1
	public GameObject atomPrefab; // 2
	public List<Transform> atomSpawnPositions = new List<Transform>(); // 3
	public float timeBetweenSpawns; // 4
	private List<GameObject> atomList = new List<GameObject>(); // 5


	void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

   private void SpawnAtom()
	{
	    Vector3 randomPosition = atomSpawnPositions[Random.Range(0, atomSpawnPositions.Count)].position; // 1
	    GameObject atom = Instantiate(atomPrefab, randomPosition, atomPrefab.transform.rotation); // 2
	    atomList.Add(atom); // 3
	    atom.GetComponent<atom_move>().SetSpawner(this); // 4
	}


	private IEnumerator SpawnRoutine() // 1
	{
	    while (canSpawn) // 2
	    {
	        SpawnAtom(); // 3
	        yield return new WaitForSeconds(timeBetweenSpawns); // 4
	    }
	}

	public void RemoveAtomFromList(GameObject atom)
	{
	    atomList.Remove(atom);
	}
}
