using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using UnityEngine;

namespace Assets.Editor
{
    class FactView : EditorWindow
    {
//        private string factLable = "Fact";
        public string CurrentString = "";

        [MenuItem("Window/FactViewer")]
        public static void Init()
        {
            FactView window = (FactView)EditorWindow.GetWindow(typeof(FactView));
            window.Show();
        }

        public void OnGUI()
        {

        }



    }
}
