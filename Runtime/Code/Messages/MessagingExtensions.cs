// MessagingExtensions.cs
// Auto-Generated 6/22/2022 9:52:48 PM
using System.Collections.Generic;
using OddCommon.Messaging;
using OddCommon.Lifecycle;


public static class MessagingExtensions
{
    #region ILifecycleBackground
    public static void LifecycleBackgroundEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
    {
        List<ILifecycleBackground> allListeners = MessagingManager.GetRegisteredListeners<ILifecycleBackground>(messagingManager, "LifecycleBackground");
        foreach (ILifecycleBackground listener in allListeners)
        {
            listener.LifecycleBackground(timeSinceStartup);
        }
    }
    #endregion

    #region ILifecycleForeground
    public static void LifecycleForegroundEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
    {
        List<ILifecycleForeground> allListeners = MessagingManager.GetRegisteredListeners<ILifecycleForeground>(messagingManager, "LifecycleForeground");
        foreach (ILifecycleForeground listener in allListeners)
        {
            listener.LifecycleForeground(timeSinceStartup);
        }
    }
    #endregion

    #region ILifecycleQuit
    public static void LifecycleQuitEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
    {
        List<ILifecycleQuit> allListeners = MessagingManager.GetRegisteredListeners<ILifecycleQuit>(messagingManager, "LifecycleQuit");
        foreach (ILifecycleQuit listener in allListeners)
        {
            listener.LifecycleQuit(timeSinceStartup);
        }
    }
    #endregion

    #region ILifecycleStart
    public static void LifecycleStartEvent(this OddCommon.Messaging.MessagingManager messagingManager, System.Single timeSinceStartup)
    {
        List<ILifecycleStart> allListeners = MessagingManager.GetRegisteredListeners<ILifecycleStart>(messagingManager, "LifecycleStart");
        foreach (ILifecycleStart listener in allListeners)
        {
            listener.LifecycleStart(timeSinceStartup);
        }
    }
    #endregion
}
