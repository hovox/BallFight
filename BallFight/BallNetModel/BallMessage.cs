﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BallNetModel
{
    [DataContract]
    public class BallMessage
    {

        [DataMember]
        public BallUser User { set; get; }
        [DataMember]
        public string Message { set; get; }
        [DataMember]
        public DateTime Date { set; get; }
        [DataMember]
        public System.Windows.Thickness Margine { get; set; }

        public override string ToString()
        {
            return User==null?"":User.UserName + " Margine =" + Margine;
        }
    }
}
