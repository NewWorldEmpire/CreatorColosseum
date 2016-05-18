using UnityEngine;
using System.Collections;

public class SkipLevel : MonoBehaviour {

	public GameObject _levelSelect;
	public GameObject enemies1;
	public GameObject enemies2;
	public GameObject enemies3;
	public GameObject enemies4;
	public GameObject hedgehogs;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp("p")) 
		{
			_levelSelect.GetComponent<Transitions>().levelSelect++;
			enemies1.gameObject.SetActive(false);
			enemies2.gameObject.SetActive(false);
			enemies3.gameObject.SetActive(false);
			enemies4.gameObject.SetActive(false);
			hedgehogs.SetActive(false);

		}
	}
}
