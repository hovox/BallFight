﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BallNetModel
{
    [DataContract]
    public class BallUser
    {
        [DataMember]
        public string UserName { set; get; }
        [DataMember]
        public string Key { set; get; }
        [DataMember]
        public string AppAddress { set; get; }
        [DataMember]
        public string HostName { set; get; }
        [DataMember]
        public bool IsFirstUser { get; set; }

        public override string ToString()
        {
            return this.UserName +" "+ AppAddress;
        }
    }

}
