using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSDK
{
    class ListViewItemCollection : ObservableCollection<IListViewItem>
    {
        public string Header { get; }

        public ListViewItemCollection(string header)
        {
            this.Header = header;
        }
    }
}
