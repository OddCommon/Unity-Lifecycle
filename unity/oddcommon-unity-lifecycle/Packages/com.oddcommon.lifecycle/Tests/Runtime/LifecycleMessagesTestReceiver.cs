using OddCommon.Debug;
using OddCommon.Messaging;


namespace OddCommon.Lifecycle.Tests
{
    public class LifecycleMessagesTestReceiver : MessagingBehaviour<LifecycleMessagesTestReceiver, LifecycleRuntimeData>, ILifecycle
    {
        #region ILifecycle
        public void LifecycleStart(float timeSinceStartup)
        {
            Logging.Log
            (
                "[{0}] LifecycleStart message received with argument timeSinceStartup = {1}.",
                nameof(LifecycleMessagesTestReceiver),
                timeSinceStartup
            );
        }

        public void LifecycleForeground(float timeSinceStartup)
        {
            Logging.Log
            (
                "[{0}] LifecycleForeground message received with argument timeSinceStartup = {1}.",
                nameof(LifecycleMessagesTestReceiver),
                timeSinceStartup
            );
        }

        public void LifecycleBackground(float timeSinceStartup)
        {
            Logging.Log
            (
                "[{0}] LifecycleBackground message received with argument timeSinceStartup = {1}.",
                nameof(LifecycleMessagesTestReceiver),
                timeSinceStartup
            );
        }

        public void LifecycleQuit(float timeSinceStartup)
        {
            Logging.Log
            (
                "[{0}] LifecycleQuit message received with argument timeSinceStartup = {1}.",
                nameof(LifecycleMessagesTestReceiver),
                timeSinceStartup
            );
        }
        #endregion //IApplication
    }   
}