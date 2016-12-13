using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Group5MVVM
{
    class ItemModel : INotifyPropertyChanged
    {
        public List<RetailItem> AllItemList
        {
            get { return _AllItemList; }
            set { _AllItemList = value; OnPropertyChanged(); }
        }
        private List<RetailItem> _AllItemList;
        public ItemModel()
        {
            RetailItem[] itemArray = new RetailItem[3];
            itemArray[0] = new RetailItem("Jacket", 12, 59.95 );
            itemArray[1] = new RetailItem("Jeans", 40, 34.95);
            itemArray[2] = new RetailItem("Shirt", 20, 24.95);

            _AllItemList = itemArray.ToList();
            AllItemList = _AllItemList;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
