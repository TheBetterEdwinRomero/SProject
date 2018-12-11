using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

    public Transform m_CameraTarget;
    public float m_ScreenEdgeLimit = 5f;
    public float m_DelayTime = 0.2f;
    private float m_CamDistance = 25;

    private Camera m_Camera;
    public Vector3 m_TargetPosition;
    private Vector3 m_CameraVelocity;

    // Use this for initialization

    private void Awake()
    {

        m_Camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = new Vector3();
        position = m_CameraTarget.position;
        position.y = m_CamDistance;
        transform.position = Vector3.SmoothDamp(transform.position, position, ref m_CameraVelocity, m_DelayTime);
    }

    public void SetCameraPosition()
    {

        transform.position = m_TargetPosition;
    }

}
