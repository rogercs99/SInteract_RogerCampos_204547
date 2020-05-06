using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimana : MonoBehaviour
{
	public static uimana Instance; 
    public int atom_corta;
    public Text contador;
    public GameObject ganador;


    // Start is called before the first frame update
    void Awake()
    {
        atom_corta = 0;
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        comprobar();
    }


    void comprobar(){

    	if (atom_corta >= 4){
    		ganador.SetActive(true);
    	}

    }


}
