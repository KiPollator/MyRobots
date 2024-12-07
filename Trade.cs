using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Trade
    {
        //----------------------------поля----------------------------------------------------
        #region Fields
        //----------------ORDERS---
        /// <summary>
        /// цена инструмента
        /// </summary>
        public decimal Praices = 0;
        public string _Symvol = "";
        string _SymvolCode = "";
        public DateTime Time = DateTime.MinValue;
        string Portfolio = "";
        //--------------------------
        #endregion
        //----------------VOLUME---
        #region Properties

        /// <summary>
        /// объём сделки
        /// </summary>
        public decimal Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                _volume = value;
            }
        }
        decimal _volume = 0;
        //--------------------------
        #endregion


    }
}
