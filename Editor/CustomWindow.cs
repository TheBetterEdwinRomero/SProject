using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Assets.Scripts;

public class CustomWindow : EditorWindow {

    public string CurrentString = "";
    public List<RuleObject> CurrentRuleList;
    [MenuItem("Window/RuleEditor")]
    public static void Init()
    {
        CustomWindow window = (CustomWindow)EditorWindow.GetWindow(typeof(CustomWindow));
        window.Show();
    }

    public void OnGUI()
    {

        //Need to populate the data before using it.

        if (CurrentRuleList == null)
        {
        CurrentRuleList = FindObjectOfType<RuleList>().Rules;
        }


        GUILayout.Label("RuleView", EditorStyles.boldLabel);

        if (GUILayout.Button("Add Rule"))
        {
        GUILayout.TextField("Work",GUILayout.ExpandHeight(true));
            EditorUtility.FocusProjectWindow();

        }
        if (GUI.changed)
        {
            Repaint();
        }

        //            Rules.Add(new RuleObject(new List<FactObject>(),""));
        //            GUILayout.Label(Rules[0].ToString());
        //        GUILayout.Label(((RuleObject)EditorGUILayout.ObjectField(Rules[0], typeof(RuleObject))).name);
    }

    void OnInspectorUpdate()
    {
        Repaint();
    }


}


/*
 * Create a button to set amount of rules
 * look into GUI
 * file:///D:/yoonity/Editor/Data/Documentation/en/ScriptReference/GUILayout.Box.html
 * https://docs.unity3d.com/ScriptReference/EditorGUI.ObjectField.html
 * 
 * 
 */
