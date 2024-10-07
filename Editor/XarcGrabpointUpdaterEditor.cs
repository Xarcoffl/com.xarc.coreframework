using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Xarc
{
    [CustomEditor(typeof(XarcGrabpointUpdater))]
    [CanEditMultipleObjects]
    public class XarcGrabpointUpdaterEditor : Editor
    {

        XarcGrabpointUpdater updater;

        void OnEnable()
        {

        }

        public override void OnInspectorGUI()
        {

            updater = (XarcGrabpointUpdater)target;

            EditorGUILayout.HelpBox("This component will help you autmatically update your grab points, as the default hand model positions have changed since Xarc v1.7. Click the 'Updated Pose' button to update the grab points in the editor. You can preview the changes in play mode before applying the changes in the editor.", MessageType.Info);

            if (GUILayout.Button("Update Pose"))
            {
                updater.ApplyGrabPointUpdate();
            }

            EditorGUILayout.Separator();

            serializedObject.ApplyModifiedProperties();

            base.OnInspectorGUI();
        }
    }
}
