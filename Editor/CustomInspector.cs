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
    public class CustomInspector : Editor
    {
        RuleObject Rule;
        



         public override void OnInspectorGUI()
         {
             RuleObject qc = (RuleObject)target;

             EditorGUILayout.LabelField("Rules", qc.ToString());

         }

    }

}

/*
 


 */