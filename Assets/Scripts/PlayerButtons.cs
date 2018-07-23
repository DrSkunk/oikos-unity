using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor (typeof (Player))]
public class PlayerButtons : Editor {
        public int x = 1;
        public int y = 0;

        public override void OnInspectorGUI () {
            DrawDefaultInspector ();

            // GUILayout.TextField (x, 25);
            // GUILayout.TextField (y, 25);

            Player myScript = (Player) target;
            if (GUILayout.Button ("Set player position")) {
                myScript.SetPosition (this.x, this.y);
                }
            }
        }