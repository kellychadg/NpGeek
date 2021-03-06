﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Web.Models;

namespace Capstone.Web.DAL
{
    public interface IParkDAL
    {
        List<Park> GetAllParks();
        Park GetPark(string parkCode);
        void SaveSurvey(Survey newSurvey);
        Park GetSurveyLeader();
        List<Weather> GetFiveDayForecast(string parkCode);
    }
}
