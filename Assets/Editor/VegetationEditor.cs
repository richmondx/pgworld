﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(Vegetation))]
public class VegetationEditor : Editor {
	public override void OnInspectorGUI () {
		DrawDefaultInspector();

		Vegetation vegetation = (Vegetation)target;

		if (GUILayout.Button("Run texturing")) {
			vegetation.RunTexturing();
		}

		if (GUILayout.Button("Run tree generator")) {
				vegetation.RunTreeGenerator();
		}
	}

}

[CustomEditor(typeof(BasicTextureVegetation))]
public class BasicTextureVegetationEditor : VegetationEditor {}