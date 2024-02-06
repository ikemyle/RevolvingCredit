using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace RevolvingCredit.Data
{
    public class Customer : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _busname;
        private string _address;
        private string _city;
        private string _phone;
        private string _title;
        private bool _contractinprogress;

        public Customer()
        {

        }

        public Customer(int id, string name, string businesName, string address, string city, string phone, string title, bool contractInProgress = false)
        {
            this.Id = id;
            this.ContractId = id + 999;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.Phone = phone;
            this.BusinessName = businesName;
            this.Title = title;
            this.ContractInProgress = contractInProgress;
        }
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged("Id");
            }
        }
        public int ContractId { get; }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
                OnPropertyChanged("Name");
            }
        }
        public string BusinessName
        {
            get
            {
                return this._busname;
            }
            set
            {
                this._busname = value;
                OnPropertyChanged("BusinessName");
            }
        }

        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
                OnPropertyChanged("Title");
            }
        }


        public string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
                OnPropertyChanged("Address");
            }
        }

        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
                OnPropertyChanged("City");
            }
        }

        public string Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                this._phone = value;
                OnPropertyChanged("Phone");
            }
        }

        public bool ContractInProgress
        {
            get
            {
                return this._contractinprogress;
            }
            set
            {
                this._contractinprogress = value;
                OnPropertyChanged("Phone");
            }
        }

        public bool IsBusiness
        {
            get
            {
                return !String.IsNullOrEmpty(this.BusinessName);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
