using System;
using System.Collections.Generic;
using System.Text;

namespace TradingApp.TickerObjects
{
    class StockTicker
    {
        // Holds All Data for Single Stock Ticker

        protected string _name;
        protected string _market;
        
        protected string _dateStart;
        protected string _dateEnd;
        protected int _daysTraded;

        public StockTicker (string tickerName, string market)
        {
            // Constructor for new StockTicker Instance
            _name = tickerName;
            _market = market;
            LastUpdate = DateTime.Now;
        }

        public DateTime LastUpdate { get; internal set; }


    }
}
