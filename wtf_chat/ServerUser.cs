﻿
using System.ServiceModel;

namespace wtf_chat
{
    class ServerUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public OperationContext operationContext { get; set; }

    }
}
