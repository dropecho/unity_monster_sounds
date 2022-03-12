using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(Timing))]
public class TimingPropertyDrawer : PropertyDrawer {
  // Draw the property inside the given rect
  public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
    // Using BeginProperty / EndProperty on the parent property means that
    // prefab override logic works on the entire property.
    EditorGUI.BeginProperty(position, label, property);

    // Draw label
    position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

    // Calculate rects
    var width = position.width / 2;
    var startRect = new Rect(position.x, position.y, width - 5, position.height - 3);
    var endRect = new Rect(position.x + width + 5, position.y, width - 5, position.height - 3);

    EditorGUI.PropertyField(startRect, property.FindPropertyRelative(nameof(Timing.min)), GUIContent.none);
    EditorGUI.PropertyField(endRect, property.FindPropertyRelative(nameof(Timing.max)), GUIContent.none);

    EditorGUI.EndProperty();
  }
}