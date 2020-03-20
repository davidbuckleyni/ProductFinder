using System;

namespace ProductFinderDal.Models
{
	public class Products
    {
        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        private bool _isAvailable;
        public bool isAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        private int _storeId;
        public int storeId
        {
            get { return _storeId; }
            set { _storeId = value; }
        }

        private int _Qty;
        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        private int _priceId;
        public int priceId
        {
            get { return _priceId; }
            set { _priceId = value; }
        }

        private bool _isDeleted;
        public bool isDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        private bool _isActive;
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        private DateTime _lastUpdate;
        public DateTime lastUpdate
        {
            get { return _lastUpdate; }
            set { _lastUpdate = value; }
        }

    }
}