
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.PME
{

[CreateAssetMenu(fileName = "Data", menuName = "RuleListObject", order = 1)]
public class RuleList : ScriptableObject {
    public List<RuleObject> Rules;

    //used for rule editing.
    //This object is used to display Rule Objects and their data
/*	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
}
