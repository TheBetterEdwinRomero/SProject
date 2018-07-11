using System;
using System.Text;

using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Provides the information of 
    /// the rule object 
    /// Displays data of each fact object associated with the given value by the user.
    /// Allows for creating and adding facts and rule objects.
    /// </summary>
    [CustomEditor(typeof(RuleObject))]
    public class CustomInspector : EditorWindow
    {
        [MenuItem("Window/RuleInspector")]
        static void Init()
        {
            CustomInspector window = (CustomInspector)EditorWindow.GetWindow(typeof(CustomInspector));
            window.Show();
        }


        void OnGUI()
        {
            GUILayout.Label("Base Settings", EditorStyles.boldLabel);
            EditorGUILayout.TextField("RuleGoesHere?", "RuleVale");
            EditorGUILayout.Space();

            /*3 columns*/
        }

        //SampleCode
        /*  private void OnInspectorGUI()
        {
            EditorGUILayout.TextField("Rule", EditorGUILayout);
        }
         public override void OnInspectorGUI()
         {
             RuleObject qc = (RuleObject)target;
             size = qc.FactCount;
             EditorGUILayout.TextField("Rules", qc.Response);

         }*/

    }

}

