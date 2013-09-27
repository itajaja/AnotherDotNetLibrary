using System;
using System.Diagnostics;
using System.Windows.Input;

namespace Adnl.Windows.Input
{
    /// <summary>
    /// Defines a command with the possibility to define an Action.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Fields

        private readonly Action<object> _execute;
        private readonly Predicate<object> _canExecute;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the RelayCommand class with the specified action.
        /// </summary>
        /// <param name="execute">The action to be executed by the command</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the RelayCommand class with the specified action and execution condition.
        /// </summary>
        /// <param name="execute">The action to be executed by the command</param>
        /// <param name="canExecute">The condition to be tested for execution</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");
            _execute = execute;
            _canExecute = canExecute;
        }

        #endregion

        #region ICommand Members

        /// <summary>
        /// Determines whether this RelayCommand can execute in its current state.
        /// </summary>
        /// <returns>
        /// true if the command can execute, otherwise, false.
        /// </returns>
        /// <param name="parameter">A user defined parameter</param>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Occurs when changes to the command source are detected by the command manager. These changes often affect whether the command should execute on the current command target.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Executes the RelayCommand with the specified parameter.
        /// </summary>
        /// <param name="parameter">User defined parameter to be passed to the handler.</param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        #endregion
    }
}