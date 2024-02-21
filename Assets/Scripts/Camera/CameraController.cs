using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] 
    private Transform _player;

    [SerializeField]
    private Vector3 _offset;

    [SerializeField] 
    private Vector3 _cameraSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Get player transform instance
        this._player = GameObject.FindGameObjectWithTag("Player").transform;

        // Get current camera offset
        this._offset = transform.position - this._player.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Counting new camera position
        var targetPosition = this._player.position + this._offset;

        // Move camera to target position using SmoothDamp
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref this._cameraSpeed, 0.3f);
    }
}
