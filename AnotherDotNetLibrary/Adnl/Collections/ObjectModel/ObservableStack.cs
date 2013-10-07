using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Adnl.Collections.ObjectModel
{
    /// <summary>
    /// Represent a stack that notifies listeners of dynamic changes, such as when items get pushed and popped or the whole stack is cleared.
    /// </summary>
    public class ObservableStack<T> : Stack<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableStack()
        {
        }

        public ObservableStack(IEnumerable<T> collection)
        {
            foreach(var i in collection)
                base.Push(i);
        }

        /// <summary>
        /// Removes all objects from the stack.
        /// </summary>
        public new void Clear()
        {
            base.Clear();
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        /// <summary>
        /// Removes and returns the object at the top of the Stack.
        /// </summary>
        /// <returns>
        /// The object removed from the top of the Stack.
        /// </returns>
        /// <exception cref="T:System.InvalidOperationException">The stack is empty.</exception>
        public new T Pop()
        {
            T item = base.Pop();
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, Count));
            return item;
        }

        /// <summary>
        /// Inserts an object at the top of the Stack.
        /// </summary>
        /// <param name="item">The object to push onto the stack. The value can be null for reference types.</param>
        public new void Push(T item)
        {
            base.Push(item);
            RaiseCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, 0));
        }

        private void RaiseCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if (CollectionChanged != null) CollectionChanged(this, e);
        }
    }
}