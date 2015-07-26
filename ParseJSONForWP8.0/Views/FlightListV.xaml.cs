using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ParseJSONForWP8._0.Controllers;
using ParseJSONForWP8._0.ViewModel;

namespace ParseJSONForWP8._0.Views
{
    public partial class FlightListV : PhoneApplicationPage
    {
        private  string searchKey;
        public FlightListV()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            ////删除前一个页面
            //if (this.NavigationService.CanGoBack)
            //{
            //    this.NavigationService.RemoveBackEntry();
            //}

            //获得 主页面 传来的 厕所 id号
            searchKey = this.NavigationContext.QueryString["searchKey"];
            FlightListC flightListC = new FlightListC(this);
            flightListC.getTuRingReply(searchKey);
      
        }


        public void updateContent(Object result)
        {
            Deployment.Current.Dispatcher.BeginInvoke(() =>
            {
                this.DataContext = result;
                //this.flightList.Items.Clear();
                //this.flightList.ItemsSource = result.List;
            });
        }
    }
}