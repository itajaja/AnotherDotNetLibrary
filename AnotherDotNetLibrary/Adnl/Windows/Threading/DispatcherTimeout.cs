using System;
using System.Windows.Threading;

namespace Adnl.Windows.Threading
{
    /// <summary>
    ///     A dispatcherTimer subclass that fires only once
    /// </summary>
    public class DispatcherTimeout : DispatcherTimer
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the DispatcherTimeout class which processes timer events at the specified priority.
        /// </summary>
        /// <param name="priority">The priority at which to invoke the timer.</param>
        protected DispatcherTimeout(DispatcherPriority priority)
            : base(priority)
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the callback which should be called on tick.
        /// </summary>
        public Action<DispatcherTimeout> Callback { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Instantiates a new DispatcherTimeout and starts it.
        /// </summary>
        /// <param name="priority">
        ///     The dispatcher priority used for the timer.
        /// </param>
        /// <param name="duration">
        ///     The duration.
        /// </param>
        /// <param name="callback">
        ///     The callback which should be called on tick.
        /// </param>
        /// <returns>
        ///     An instance of DispatcherTimeout.
        /// </returns>
        public static DispatcherTimeout Timeout(DispatcherPriority priority, TimeSpan duration, Action<DispatcherTimeout> callback)
        {
            if (duration < TimeSpan.Zero) duration = TimeSpan.Zero;
            var dispatcherTimeout = new DispatcherTimeout(priority) { Interval = duration, Callback = callback };
            dispatcherTimeout.Tick += dispatcherTimeout.HandleTick;
            dispatcherTimeout.Start();
            return dispatcherTimeout;
        }

        #endregion

        #region Methods

        private void HandleTick(object sender, EventArgs e)
        {
            Stop();
            Tick -= HandleTick;

            if (Callback != null)
            {
                Callback(this);
            }
        }

        #endregion
    }
}