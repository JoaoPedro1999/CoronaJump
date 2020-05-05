using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Ui;

public class corona : MonoBehaviour
{

	public Text txtvidas;
	private static int vidas = 5;

    // Start is called before the first frame update
    void Start()
    {
	vidas = 5;    
        txtvidas.text = "Vidas: " + vidas;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider outro) {
        if(outro.gameObject.CompareTag("azul")) {
   	   vidas--;
	   txtvidas.text = "Vidas: " + vidas;
           SceneManager.LoadScene(0);
        }
    }

}
