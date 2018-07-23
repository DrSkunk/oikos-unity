using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int tileX;
	public int tileY;
	public GameObject towers;

	// Use this for initialization
	void Start () {
		this.gameObject.transform.Rotate (0, 0, Random.Range (0, 360));
	}

	public void SetPosition (int x, int y) {
		Tower tower = towers.transform.GetChild (0).GetComponent (typeof (Tower)) as Tower;
		float z = 0;
		switch (tower.stage) {
			case 0:
			default:
				break;
			case 1:
				z = 0.7f;
				break;
			case 2:
				z = 1.33f;
				break;
			case 3:
				z = 1.934f;
				break;
		}
		Debug.Log (x + "" + y);
		this.tileX = x;
		this.tileY = y;
		transform.position = new Vector3 (x - 2, z, y - 2);
	}

	// Update is called once per frame
	void Update () {

	}
}