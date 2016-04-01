using UnityEngine;
using System.Collections;

public class CharactersOnMinimap : MonoBehaviour {

	public GameObject player;
	public Texture2D playerArrow;
	public Camera minimapCamera;
	public Rect arrowRect;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {

	}

	void OnGUI () {
		if (minimapCamera.enabled == true) {
			Vector3 Position = minimapCamera.WorldToViewportPoint (player.transform.position);
			float angle = player.transform.eulerAngles.y;
			Matrix4x4 guiRotationMatrix = GUI.matrix;
			Vector2 pivot;
			pivot.x = Screen.width * (minimapCamera.rect.x + (Position.x * minimapCamera.rect.width));
			pivot.y = Screen.height * (minimapCamera.rect.y + (Position.y * minimapCamera.rect.height));

			arrowRect = new Rect (pivot.x - 10, pivot.y * 3.9f, 12, 12);
			GUIUtility.RotateAroundPivot (angle, arrowRect.center);
			GUI.DrawTexture (arrowRect, playerArrow);
		}
	}
}
