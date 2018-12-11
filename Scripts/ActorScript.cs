using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PME
{
    /// <summary>
    /// A script that will demonstrate the pattern matching engine
    /// </summary>
    public class ActorScript : MonoBehaviour
    {
        int layer;
        public float CoolDownTimer;
        public float DialogueDuration;
        public float ViewDistance;
        public RuleList Rules;
        public Text TextBox;
        public Camera camera;

        private QueryController Qc;
        private ResponseQuery Response;
        [HideInInspector]
        public string Dialogue;
        
        private float time;
        private float dtime;
        private Vector3 worldUp = Vector3.up;

        public void Start()
        {
           
           Qc = new QueryController(Rules);
            layer = 1 << 8;
            time = CoolDownTimer;
            dtime = DialogueDuration;


        }

        public void FixedUpdate()
        {
            //            TextBox.rectTransform.LookAt(camera.transform);
            //            transform.rotation = Quaternion.LookRotation(transform.position - target.position);
//            camera.transform.position = transform.;
//            TextBox.transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);

            if (time <= 0)
            {
                time = CoolDownTimer;                
                PerformRayCast();
               
            }
            if ((time > 0 && time <= (CoolDownTimer-DialogueDuration)) && TextBox.text != "")
            {
            TextBox.text = "";
            }
          
            time = time - Time.fixedUnscaledDeltaTime;
          
        }
    
        public void PerformRayCast()
        {
            Response = new ResponseQuery();
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, ViewDistance,layer)){
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
               
                Response.Add("What", hit.transform.tag);
                Response.Add("Distance", ((int)hit.distance).ToString());
                TextBox.text = Qc.Speak(Response);

            }
        }
    }
}


/*

!!!
As a dev I want to know what keywords I can use
As a dev I want to have a key word to hold an event
on event perform an update on the query.


    responses are made and immedietly forgotten.
    save responses and add to them.

    solution:
    a memory variable to be used in actor script
    a remember function on a successful query

    TODO: prepare a presentable demo of this project

!!!

*/
