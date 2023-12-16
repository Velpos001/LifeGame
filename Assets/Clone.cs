using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    //Room for GameObject
    public GameObject _cube;
    //Vector3 for remembering the spawn points.
    public Vector3 _spawnP;
    private float _lastPos = 0.0f;
    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            // Instantiate the cube at the desired position.
            Instantiate(_cube, _spawnP + new Vector3(_lastPos, 0, 0), Quaternion.identity);
            Debug.Log("locating");
            // Increment the last cube position by 5.0f.
            _lastPos += 5.0f;

        }
    }
}
