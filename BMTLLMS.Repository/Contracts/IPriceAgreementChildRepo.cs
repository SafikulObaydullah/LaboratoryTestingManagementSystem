﻿using BMTLLMS.Domain.Models.Configuration;
using BMTLLMS.Domain.ViewModel;
using BMTLLMS.Domain.ViewModel.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMTLLMS.Repository.Contracts
{
   public interface IPriceAgreementChildRepo
   {
      SaveVM SavePriceAgreementChild(PriceAgreementChildVM obj);
      IEnumerable<PriceAgreementChildVM> GetPriceAgreementChild(Int64 Id);
   }
}
