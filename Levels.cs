using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    public class Levels
    {
        //---------------------------конструктор-------------------------
        public Levels(decimal praice) 
        { 
        
        }
        //----------------------------Поля-------------------------------
        #region Fields
        /// <summary>
        /// цена уровня
        /// </summary>
        public decimal Praice = 0;
        /// <summary>
        /// лот уровня
        /// </summary>
        public decimal LotLevel = 0;
        /// <summary>
        /// Открытый объём
        /// </summary>
        public decimal Volume = 0;
        #endregion
    }
}
