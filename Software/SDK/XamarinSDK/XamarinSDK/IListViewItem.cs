using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinSDK
{
    interface IListViewItem
    {
        string Text { get; }

        string DetailText { get; }

        Color TextColor { get; }

        Color DetailTextColor { get; }
    }
}
