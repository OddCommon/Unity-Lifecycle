// MessagingExtensions.cs
// Auto-Generated 3/20/2021 9:25:24 PM
using System.Collections.Generic;
using OddCommon.Messaging;


namespace OddCommon.Lifecycle
{
    public static class MessagingExtensions
    {
        #region ILifecycleBackground
        public static void LifecycleBackgroundEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
        {
            List<ILifecycleBackground> allListeners = messagingManager.GetRegisteredListeners<ILifecycleBackground>("LifecycleBackground");
            foreach (ILifecycleBackground listener in allListeners)
            {
                listener.LifecycleBackground(timeSinceStartup);
            }
        }
        #endregion
    
        #region ILifecycleForeground
        public static void LifecycleForegroundEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
        {
            List<ILifecycleForeground> allListeners = messagingManager.GetRegisteredListeners<ILifecycleForeground>("LifecycleForeground");
            foreach (ILifecycleForeground listener in allListeners)
            {
                listener.LifecycleForeground(timeSinceStartup);
            }
        }
        #endregion
    
        #region ILifecycleQuit
        public static void LifecycleQuitEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
        {
            List<ILifecycleQuit> allListeners = messagingManager.GetRegisteredListeners<ILifecycleQuit>("LifecycleQuit");
            foreach (ILifecycleQuit listener in allListeners)
            {
                listener.LifecycleQuit(timeSinceStartup);
            }
        }
        #endregion
    
        #region ILifecycleStart
        public static void LifecycleStartEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
        {
            List<ILifecycleStart> allListeners = messagingManager.GetRegisteredListeners<ILifecycleStart>("LifecycleStart");
            foreach (ILifecycleStart listener in allListeners)
            {
                listener.LifecycleStart(timeSinceStartup);
            }
        }
        #endregion
    }   
}