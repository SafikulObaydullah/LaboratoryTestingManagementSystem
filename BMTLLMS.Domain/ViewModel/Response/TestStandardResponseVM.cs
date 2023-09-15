﻿

using BMTLLMS.Domain.Models.Configuration;
using BMTLLMS.Domain.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMTLLMS.Domain.ViewModel.Response
{
   public class TestStandardResponseVM
   {
      public string StatusCode { get; set; }
      public string StatusMessage { get; set; } = string.Empty;
      public IEnumerable<TestStandardVM> Data { get; set; }
   }
}
