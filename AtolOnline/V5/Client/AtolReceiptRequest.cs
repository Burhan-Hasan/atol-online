using AtolOnline.V5.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AtolOnline.V5.Client
{
    public class AtolReceiptRequest : AtolRequest
    {
        public Receipt Receipt { get; set; }
    }
}
