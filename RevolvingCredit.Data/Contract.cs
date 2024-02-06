using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Data
{
    public class Contract
    {
        private int _id;
        private string _brokername;
        private DateTime _startDate;
        private int _terms;
        private string _notes;
        private decimal _amount;
        private decimal _interest;
        private string _state;

        public Contract()
        {

        }

        public Contract(int id, string brokername, DateTime startDate, int terms, string notes, decimal amount, decimal interest, string state)
        {
            this.Id = id;
            this.BrokerName = brokername;
            this.StartDate = startDate;
            this.YearsTerms = terms;
            this.Notes = notes;
            this.Amount = amount;
            this.Interest = interest;
            this.State = state;
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
        public string Notes
        {
            get
            {
                return this._notes;
            }
            set
            {
                this._notes = value;
                OnPropertyChanged("Notes");
            }
        }
        public DateTime StartDate
        {
            get
            {
                return this._startDate;
            }
            set
            {
                this._startDate = value;
                OnPropertyChanged("StartDate");
            }
        }
        public int YearsTerms
        {
            get
            {
                return this._terms;
            }
            set
            {
                this._terms = value;
                OnPropertyChanged("YearsTerms");
            }
        }
        public decimal Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
                OnPropertyChanged("Amount");
            }
        }
        public decimal Interest
        {
            get
            {
                return this._interest;
            }
            set
            {
                this._interest = value;
                OnPropertyChanged("Interest");
            }
        }
        public string BrokerName
        {
            get
            {
                return this._brokername;
            }
            set
            {
                this._brokername = value;
                OnPropertyChanged("BrokerName");
            }
        }
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
                OnPropertyChanged("State");
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
