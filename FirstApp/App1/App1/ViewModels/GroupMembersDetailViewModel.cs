using System;
using System.Linq;
using System.Threading.Tasks;

using App1.Core.Models;
using App1.Core.Services;
using App1.Helpers;

namespace App1.ViewModels
{
    public class GroupMembersDetailViewModel : Observable
    {
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { Set(ref _item, value); }
        }

        public GroupMembersDetailViewModel()
        {
        }

        public async Task InitializeAsync(long orderID)
        {
            var data = await SampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }
}
