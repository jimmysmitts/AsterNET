﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsterNET.Manager.Event
{
    public class ConfbridgeMuteEvent : AbstractConfbridgeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        public string CallerIDnum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CallerIDname { get; set; }

        public ConfbridgeMuteEvent(ManagerConnection source)
            : base(source)
        {
        }
    }
}