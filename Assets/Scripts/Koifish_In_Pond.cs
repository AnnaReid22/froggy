using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koifish_In_Pond : MonoBehaviour
{
	public GameObject parent_koifish;
	public GameObject child_koifish;
	private Collider2D ck_pc;
	private int parent_score = 0;
	private int child_score = 0;
    // Start is called before the first frame update
    void Start()
    {
		ck_pc = child_koifish.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(other.name);
		if(other.name == "Completed Pond")
		{
			Debug.Log("collided with Completed Pond");
		}
		
	}
}
