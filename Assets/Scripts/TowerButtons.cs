using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (Tower))]
public class TowerButtons : Editor {
	public override void OnInspectorGUI () {
		DrawDefaultInspector ();

		Tower myScript = (Tower) target;
		if (GUILayout.Button ("Add stage")) {
			myScript.AddStage ();
		} else if (GUILayout.Button ("Remove stage")) {
			myScript.RemoveStage ();
		}
	}
}