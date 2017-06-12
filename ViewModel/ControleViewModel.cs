using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using ePortaria.Model;
using Plugin.BLE;
using Plugin.BLE.Abstractions.Contracts;
using Xamarin.Forms;

namespace ePortaria.ViewModel
{
    public class ControleViewModel : ViewModelBase, INotifyPropertyChanged
    {

        private int _id;
        private string _descricao;
        private string _conexao;
        private string _status;
        private string _ip;
        private string _nome_bluetooth;
        private int _estabelecimento;
        private ObservableCollection<Model.Controle> _listaControle;

        public ICommand SendCommand { get; private set; }

        public int Id
        {
            get { return _id; }
            set
            {
                if (value != _id)
                {
                    _id = value;
                    OnPropertyChanged("Id");
                }
            }
        }
        public string Descricao
        {
            get { return _descricao; }
            set
            {
                if (value != _descricao)
                {
                    _descricao = value;
                    OnPropertyChanged("Descricao");
                }
            }
        }
        public string Conexao
        {
            get { return _conexao; }
            set
            {
                if (value != _conexao)
                {
                    _conexao = value;
                    OnPropertyChanged("Conexao");
                }
            }
        }
        public string Status
        {
            get { return _status; }
            set
            {
                if (value != _status)
                {
                    _status = value;
                    OnPropertyChanged("Status");
                }
            }
        }
        public string Ip
        {
            get { return _ip; }
            set
            {
                if (value != _ip)
                {
                    _ip = value;
                    OnPropertyChanged("Ip");
                }
            }
        }
        public string NomeBluetooth
        {
            get { return _nome_bluetooth; }
            set
            {
                if (value != _nome_bluetooth)
                {
                    _nome_bluetooth = value;
                    OnPropertyChanged("NomeBluetooth");
                }
            }
        }


        public ObservableCollection<Model.Controle> ListaControle
        {
            get
            {
                if (_listaControle != null)
                {
                    return _listaControle;
                }
                else
                {
                    _listaControle = new ObservableCollection<Model.Controle>();
                    return _listaControle;
                }
            }

            set
            {
                _listaControle = value;
                OnPropertyChanged("ListaControle");
            }
        }

        public int Estabelecimento
        {
            get { return _estabelecimento; }
            set
            {
                if (value != _estabelecimento)
                {
                    _estabelecimento = value;
                    OnPropertyChanged("Estabelecimento");
                }
            }
        }

        public async Task<ObservableCollection<IDevice>> ListarDispositivos(IAdapter adapter)
        {
            ObservableCollection<IDevice> deviceList = new ObservableCollection<IDevice>();
			adapter.DeviceDiscovered += (s, a) => deviceList.Add(a.Device);
			await adapter.StartScanningForDevicesAsync();

            return deviceList;
        }

        public  ControleViewModel()
        {
            
            SendCommand = new Command(EnviarCommando);

            var ble = CrossBluetoothLE.Current;
            var adapter = CrossBluetoothLE.Current.Adapter;
            var state = ble.State;
            //ble.StateChanged += (s, e) =>
            //    {
            //        Debug.WriteLine($"The bluetooth state changed to {e.NewState}");
            //    };

            ListarDispositivos(adapter);

        }

        public void AddControles(ObservableCollection<Estabelecimento> listaEstabelecimento)
        {
            foreach (var estabelecimento in listaEstabelecimento)
            {
                foreach (ePortaria.Model.Controle controle in GetLista<ePortaria.Model.Controle>())
                {
                    if (controle.estabelecimento == estabelecimento.Id)
                    {
                        if (estabelecimento.Controle == null)
                        {
                            estabelecimento.Controle = new List<Model.Controle>();
                        }
                        estabelecimento.Controle.Add(controle);
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nome)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(nome));
        }

        void EnviarCommando()
        {
            //Helper.RequestClient.SendControle(this.Ip, "dadosComando");
            Debug.WriteLine(this.Ip);
        }

    }
}
