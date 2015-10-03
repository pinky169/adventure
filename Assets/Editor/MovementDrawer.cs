using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomPropertyDrawer (typeof (Movement))]
public class MovementDrawer : PropertyDrawer 
{
	// Draw the property inside the given rect
	public override void OnGUI (Rect position, SerializedProperty property, GUIContent label) {
		// Using BeginProperty / EndProperty on the parent property means that
		// prefab override logic works on the entire property.
		EditorGUI.BeginProperty (position, label, property);
		
		// Draw label
		position = EditorGUI.PrefixLabel (position, GUIUtility.GetControlID (FocusType.Passive), label);
		position.height = position.height * 2;
		
		// Don't make child fields be indented
		var indent = EditorGUI.indentLevel;
		EditorGUI.indentLevel = 0;
		
		// Calculate rects
		// Movement and jump
		var half = (position.width - 20) / 2;
		var isMoving = new Rect (position.x, position.y, 12, 16);
		var move = new Rect (position.x +16, position.y, half, 16);
		var jump = new Rect (position.x +20 + half, position.y, half, 16);
		// Ground check
		var onGround = new Rect (position.x, position.y +18, 12, 16);
		var check = new Rect (position.x +16, position.y +18, half, 16);
		var mask = new Rect (position.x +20 + half, position.y +18, half, 16);
		
		// Draw fields - passs GUIContent.none to each so they are drawn without labels
		EditorGUI.PropertyField (isMoving, property.FindPropertyRelative ("isMoving"), GUIContent.none);
		EditorGUI.PropertyField (move, property.FindPropertyRelative ("moveSpeed"), GUIContent.none);
		EditorGUI.PropertyField (jump, property.FindPropertyRelative ("jumpSpeed"), GUIContent.none);
		
		EditorGUI.PropertyField (onGround, property.FindPropertyRelative ("onGround"), GUIContent.none);
		EditorGUI.PropertyField (check, property.FindPropertyRelative ("checkRadius"), GUIContent.none);
		EditorGUI.PropertyField (mask, property.FindPropertyRelative ("mask"), GUIContent.none);
		
		// Set indent back to what it was
		EditorGUI.indentLevel = indent;
		
		EditorGUI.EndProperty ();
	}
	
	override public float GetPropertyHeight(SerializedProperty property, GUIContent label)
	{
		return base.GetPropertyHeight(property, label) * 2 + 2;
	}
}