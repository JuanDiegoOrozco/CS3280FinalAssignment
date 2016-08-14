using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using InventoryData;
using System.Collections.ObjectModel;
using FinalAssignment.Views;
namespace FinalAssignment.ViewModels
{
    class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        private ObservableCollection<Order> icollection;
        public MainViewModel() {
            this.DisplayName = "Inventory Application";
            
            //Dummy data
            Order dummy1 = new Order();
            dummy1.OrderNumber = 1;
            dummy1.DatePlaced = DateTime.Today;
            User dumdum = new User();
            dumdum.Name = "Mike Jones";
            dumdum.Phone = "218-330-8004";
            dumdum.UserId = 1234;
            dummy1.Purchaser = dumdum;
            dummy1.TotalCost = 1000000;

            Order dummy2 = new Order();
            dummy2.OrderNumber = 2;
            dummy2.DatePlaced = DateTime.Today;
            User dumdum2 = new User();
            dumdum2.Name = "50 Cent";
            dumdum2.Phone = "435-754-8289";
            dumdum2.UserId = 5678;
            dummy2.Purchaser = dumdum2;
            dummy2.TotalCost = .50m;

            icollection = new ObservableCollection<Order>();
            icollection.Add(dummy1);
            icollection.Add(dummy2);
        }
        public ObservableCollection<Order> AllOrders
        {
            get
            {
                return icollection;
            }
        }
        protected override void OnActivate() {
            base.OnActivate();
            Orders();
        }
        public void Orders() {
            var ordersVM = IoC.Get<OrdersViewModel>();
            //IoC.Get<OrdersViewModel>();
            //OnActivate(ordersVM);
            ActivateItem(ordersVM);
        }
        //public  TheView
        //{
        //    get
        //    {
        //        return this.OrdersView;
        //    }
        //}
        private void OnActivate(OrdersViewModel ordersVM)
        {
            //throw new NotImplementedException();
        }

        //IEnumerable<Order> OrdersView{
        //    get { return icollection; }
        //}
        /////////////////////////////////////////////////////////////////
        private ObservableCollection<OrderItem> orderItems;
        public ObservableCollection<OrderItem> AllItems
        {
            get
            {
                return orderItems;
            }
        }

    }
}
