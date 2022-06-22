#if UNITY_EDITOR
// MessagingControlPanel.cs
// Auto-Generated 6/22/2022 9:54:08 PM
using UnityEngine;
using UnityEditor;
using OddCommon;
using OddCommon.Debug;
using OddCommon.Messaging;
using OddCommon.Messaging.Editor;
using System;



namespace com.oddcommon.lifecycle
{
    public class MessagingControlPanel : EditorWindow
    {
        #region Class
        #region Methods
        [MenuItem("Messaging/Lifecycle Messaging Control Panel", false, 0)]
        private static void ControlPanelWindow()
        {
            EditorWindow.GetWindow
            (
                typeof(com.oddcommon.lifecycle.MessagingControlPanel),
                false,
                "Lifecycle Messaging Control Panel",
                true
            ).Show();
            return;
        }
        #endregion //Methods
        #endregion //Class

        #region Instance
        #region Fields
        #region Private
        #region Editor Window
        private Vector2 guiScrollPosition = Vector2.zero;
        #endregion //Editor Window

        #region Message Parameters
        #region ILifecycleBackground Parameters
        private bool foldoutToggleILifecycleBackground = false;
        [HideInInspector] [SerializeField] private Single LifecycleBackgroundtimeSinceStartup;
        #endregion //ILifecycleBackground Parameters

        #region ILifecycleForeground Parameters
        private bool foldoutToggleILifecycleForeground = false;
        [HideInInspector] [SerializeField] private Single LifecycleForegroundtimeSinceStartup;
        #endregion //ILifecycleForeground Parameters

        #region ILifecycleQuit Parameters
        private bool foldoutToggleILifecycleQuit = false;
        [HideInInspector] [SerializeField] private Single LifecycleQuittimeSinceStartup;
        #endregion //ILifecycleQuit Parameters

        #region ILifecycleStart Parameters
        private bool foldoutToggleILifecycleStart = false;
        [HideInInspector] [SerializeField] private Single LifecycleStarttimeSinceStartup;
        #endregion //ILifecycleStart Parameters

        #endregion //Message Parameters
        #endregion //Private
        #endregion //Fields

        #region Methods
        #region Unity Messages
        private void OnEnable()
        {
            this.guiScrollPosition = Vector2.zero;
        }

        private void OnGUI()
        {
            SerializedObject serializedEditorWindow = new SerializedObject(this as ScriptableObject);
            this.guiScrollPosition = EditorGUILayout.BeginScrollView(this.guiScrollPosition);
            MessagingManager messagingManager = GameObject.FindObjectOfType<MessagingManager>();

            this.foldoutToggleILifecycleBackground = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleILifecycleBackground, "ILifecycleBackground");
            if(this.foldoutToggleILifecycleBackground)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("ILifecycleBackground", MessageType.Info);
                SerializedProperty serialized_LifecycleBackgroundtimeSinceStartup = serializedEditorWindow.FindProperty("LifecycleBackgroundtimeSinceStartup");
                EditorGUILayout.PropertyField(serialized_LifecycleBackgroundtimeSinceStartup, new GUIContent("timeSinceStartup"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire LifecycleBackground Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.LifecycleBackgroundEvent(this.LifecycleBackgroundtimeSinceStartup);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanel)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleILifecycleForeground = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleILifecycleForeground, "ILifecycleForeground");
            if(this.foldoutToggleILifecycleForeground)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("ILifecycleForeground", MessageType.Info);
                SerializedProperty serialized_LifecycleForegroundtimeSinceStartup = serializedEditorWindow.FindProperty("LifecycleForegroundtimeSinceStartup");
                EditorGUILayout.PropertyField(serialized_LifecycleForegroundtimeSinceStartup, new GUIContent("timeSinceStartup"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire LifecycleForeground Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.LifecycleForegroundEvent(this.LifecycleForegroundtimeSinceStartup);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanel)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleILifecycleQuit = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleILifecycleQuit, "ILifecycleQuit");
            if(this.foldoutToggleILifecycleQuit)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("ILifecycleQuit", MessageType.Info);
                SerializedProperty serialized_LifecycleQuittimeSinceStartup = serializedEditorWindow.FindProperty("LifecycleQuittimeSinceStartup");
                EditorGUILayout.PropertyField(serialized_LifecycleQuittimeSinceStartup, new GUIContent("timeSinceStartup"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire LifecycleQuit Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.LifecycleQuitEvent(this.LifecycleQuittimeSinceStartup);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanel)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            this.foldoutToggleILifecycleStart = EditorGUILayout.BeginFoldoutHeaderGroup(this.foldoutToggleILifecycleStart, "ILifecycleStart");
            if(this.foldoutToggleILifecycleStart)
            {
                EditorGUILayout.Space();
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("ILifecycleStart", MessageType.Info);
                SerializedProperty serialized_LifecycleStarttimeSinceStartup = serializedEditorWindow.FindProperty("LifecycleStarttimeSinceStartup");
                EditorGUILayout.PropertyField(serialized_LifecycleStarttimeSinceStartup, new GUIContent("timeSinceStartup"), true);;
                EditorGUILayout.BeginHorizontal();
                GUILayout.Space(EditorGUI.indentLevel * MessagingConstants.controlPanelButtonsOffset);
                if (Application.isPlaying & GUILayout.Button("Fire LifecycleStart Event "))
                {
                    if (messagingManager != null)
                    {
                        messagingManager.LifecycleStartEvent(this.LifecycleStarttimeSinceStartup);
                    }
                    else
                    {
                        Logging.Warn
                        (
                            "[{0}] MessagingManager must exist in the scene to fire message from control panel!",
                            nameof(MessagingControlPanel)
                        );
                    }
                }
                EditorGUILayout.EndHorizontal();
                EditorGUILayout.Separator();
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.EndFoldoutHeaderGroup();

            EditorGUILayout.EndScrollView();
            serializedEditorWindow.ApplyModifiedProperties();
        }
        #endregion //Unity Messages
        #endregion //Methods
        #endregion //Instance
    }
}
#endif //UNITY_EDITOR
