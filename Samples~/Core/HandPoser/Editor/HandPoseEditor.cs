using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace Xarc {

    [CustomEditor(typeof(HandPose))]
    public class HandPoseEditor : Editor {
        public override void OnInspectorGUI() {

            // HandPose pose = (HandPose)target;

            base.OnInspectorGUI();
        }
    }
}

