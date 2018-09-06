using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Custom.Notification.RNCustomNotification
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCustomNotificationModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCustomNotificationModule"/>.
        /// </summary>
        internal RNCustomNotificationModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCustomNotification";
            }
        }
    }
}
