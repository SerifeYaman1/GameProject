﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface ICampaignService
    {
        void Enter(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);

    }
}
