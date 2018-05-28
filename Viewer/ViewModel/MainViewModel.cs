using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Viewer.Model;
using Viewer.SR_Aggregated;

namespace Viewer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        ServiceAggregatedClient client = new ServiceAggregatedClient();
        public ObservableCollection<AggregatedPerson> Filtered
        {
            get => _filtered; set
            {
                _filtered = value;
                RaisePropertyChanged();
            }
        }
        private string searchZIP = "";
        private ObservableCollection<AggregatedPerson> _data;
        private ObservableCollection<AggregatedPerson> _filtered;

        public ObservableCollection<AggregatedPerson> Data
        {
            get => _data; set
            {
                _data = value;
                RaisePropertyChanged();
            }
        }
        public RelayCommand SendBtnClick { get; set; }
        public RelayCommand ResetBtnClick { get; set; }

        public string SearchZIP
        {
            get => searchZIP; set => searchZIP = value;
        }

        public MainViewModel()
        {
            Data = new ObservableCollection<AggregatedPerson>(client.GetAggregatedPersonData());
            Filtered = new ObservableCollection<AggregatedPerson>(Data);

            SendBtnClick = new RelayCommand(() =>
            {
                Filtered.Clear();
                Refresh(SearchZIP);
            }, () =>
             {
                 return !SearchZIP.Equals("") && int.TryParse(SearchZIP, out int x);
             });

            ResetBtnClick = new RelayCommand(() =>
            {
                Filtered.Clear();
                foreach (var item in Data)
                {
                    Filtered.Add(item);
                }
            });
        }

        private void Refresh(string zip)
        {
            foreach (var item in Data)
            {
                if (item.Zip.ToString().Contains(zip))Filtered.Add(item);
            }
        }
    }
}