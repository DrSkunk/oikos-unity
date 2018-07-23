using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {

	public int stage = 0;

	public void AddStage () {
		if (this.stage < 4) {
			this.stage += 1;
			this.gameObject.transform.GetChild (this.stage - 1).GetComponent<Renderer> ().enabled = true;
		}
	}

	public void RemoveStage () {
		if (this.stage > 0) {
			this.stage -= 1;
			this.gameObject.transform.GetChild (this.stage).GetComponent<Renderer> ().enabled = false;
		}
	}

	void Start () {
		this.stage = 0;
		for (int i = 0; i < 4; i++)
		{
			this.gameObject.transform.GetChild (i).GetComponent<Renderer> ().enabled = false;
		}
		for (int i = 0; i < 2; i++) {
			this.gameObject.transform.GetChild (i).transform.Rotate (0, Random.Range (0, 3) * 90, 0);
		}
	}

	void Update () {

	}
}