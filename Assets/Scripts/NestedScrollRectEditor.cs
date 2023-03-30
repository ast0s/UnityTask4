using UnityEditor;
using UnityEditor.UI;
using UnityEngine;

[CustomEditor(typeof(NestedScrollRect))]
public class NestedScrollRectEditor : ScrollRectEditor
{
    SerializedProperty parentScrollRectProp;
    GUIContent parentScrollRectGUIContent = new GUIContent("Parent ScrollRect");

    protected override void OnEnable()
    {
        base.OnEnable();
        parentScrollRectProp = serializedObject.FindProperty("parentScrollRect");
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        serializedObject.Update();
        EditorGUILayout.PropertyField(parentScrollRectProp, parentScrollRectGUIContent);
        serializedObject.ApplyModifiedProperties();
    }
}