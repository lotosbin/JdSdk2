﻿﻿using System;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain.Order;

namespace JdSdk.Response.Order
{
﻿    [Serializable]
    public class OrderSoplPrintDataGetResponse : JdResponse
    {
        [JsonProperty("order_printdata")]
        public OrderSoplPrintData ApiOrderPrintData
        {
            get;
            set;
        }

    }

}
