using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Adnl.Collections.ObjectModel
{

    /// <summary>
    /// Represents a dynamic data collection that provides notifications when items get added, removed, when the whole list is refreshed, or when any element fires a PropertyChanged Event.
    /// </summary>
    public sealed class TrulyObservableCollection<T> : ObservableCollection<T>
        where T : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the TrulyObservableCollection class.
        /// </summary>
        public TrulyObservableCollection()
        {
            CollectionChanged += TrulyObservableCollection_CollectionChanged;
        }

        private void TrulyObservableCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (T item in e.NewItems)
                {
                    item.PropertyChanged += item_PropertyChanged;
                }
            }
            if (e.OldItems != null)
            {
                foreach (T item in e.OldItems)
                {
                    item.PropertyChanged -= item_PropertyChanged;
                }
            }
        }

        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var a = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
            OnCollectionChanged(a);
        }
    }
}
