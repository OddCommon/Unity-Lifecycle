using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Assertions;
using OddCommon.Debug;
using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    public class LifecycleManager : MessagingBehaviourSingle<LifecycleManager>
    {
        #region Fields
        #region Private
        private enum LifecycleManagerState
        {
            Inactive = 0,
            Start,
            Foreground,	// Foreground + Focus
            Background,	// Backgrounded or No Focus
            Quit,
            ApplicationManagerStateCount
        }
        private LifecycleManagerState currentState;
        #endregion //Private
        #endregion //Fields

        #region Methods
        #region Unity Messages
        private void Start()
        {
            Assert.IsNotNull(this.messagingManager);
            
            this.currentState = LifecycleManagerState.Inactive;
            this.StartCoroutine(this.OnApplicationStart());
        }

        private void OnApplicationPause(bool paused)
        {
            switch (this.currentState)
            {
                case LifecycleManagerState.Foreground:
                    if (paused)
                    {
                        this.OnApplicationBackground();
                    }
                    break;
                case LifecycleManagerState.Background:
                    if (!paused)
                    {
                        this.OnApplicationForeground();
                    }
                    break;
                case LifecycleManagerState.Inactive:
                case LifecycleManagerState.Start:
                case LifecycleManagerState.Quit:
                    // NOP
                    break;
            }
        }

        private void OnApplicationFocus(bool hasFocus)
        {
            switch (this.currentState)
            {
                case LifecycleManagerState.Foreground:
                    if (!hasFocus)
                    {
                        this.OnApplicationBackground();
                    }
                    break;
                case LifecycleManagerState.Background:
                    if (hasFocus)
                    {
                        this.OnApplicationForeground();
                    }
                    break;
            }
        }

        private void OnApplicationQuit()
        {
            // If we are already quitting, we do nothing. If we
            // are in any other state we fire off the application
            // quit event.
            if (this.currentState != LifecycleManagerState.Quit)
            {
                this.currentState = LifecycleManagerState.Quit;
                Logging.Log("[{0}] Application Quit at {1}", nameof(LifecycleManager), DateTime.Now);
                this.messagingManager.LifecycleQuitEvent(Time.realtimeSinceStartup);
            }
        }
        #endregion // Unity Messages

        #region Internal Methods
        private IEnumerator OnApplicationStart()
        {
            yield return null; //Let other components start up
            this.currentState = LifecycleManagerState.Start;
            Logging.Log("[{0}] Application Start at {1}", nameof(LifecycleManager), DateTime.Now);
            this.messagingManager.LifecycleStartEvent(Time.realtimeSinceStartup);
            yield return null; //Let message listeners process ApplicationStartEvent
            this.OnApplicationForeground();
        }

        private void OnApplicationForeground()
        {
            this.currentState = LifecycleManagerState.Foreground;
            Logging.Log("[{0}] Application Foreground at {1}", nameof(LifecycleManager), DateTime.Now);
            this.messagingManager.LifecycleForegroundEvent(Time.realtimeSinceStartup);
        }

        private void OnApplicationBackground()
        {
            this.currentState = LifecycleManagerState.Background;
            Logging.Log("[{0}] Application Background at {1}", nameof(LifecycleManager), DateTime.Now);
            this.messagingManager.LifecycleBackgroundEvent(Time.realtimeSinceStartup);
        }
        #endregion //Internal Methods
        #endregion // Methods
    }
}