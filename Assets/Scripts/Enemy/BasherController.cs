using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class BasherController : MonoBehaviour
{
    [SerializeField] 
    private GameObject _player;

    [SerializeField] 
    public float WalkSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this._player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Look up to player position
        transform.LookAt(this._player.transform.position);

        // Go to player position
        transform.position += transform.forward * Time.deltaTime * WalkSpeed;
    }
}
