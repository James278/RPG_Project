using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class FollowCamera : MonoBehaviour
    {

        [SerializeField] Transform playerTransform;

        [SerializeField] Vector3 cameraOffset;

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = playerTransform.position + cameraOffset;
        }
    }
}


