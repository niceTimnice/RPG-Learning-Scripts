﻿using Packages.Rider.Editor.PostProcessors;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    
    public class MovingCam : MonoBehaviour
    {

        // Start is called before the first frame update
      public  Transform target;
        // Update is called once per frame
        void LateUpdate()
        {
            GetComponent<Rigidbody>().transform.position = target.position;
        }
    }
}
