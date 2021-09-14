using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Netflix.WebAPI.Models;

namespace Netflix.WebAPI.Data
{
    public class Data
    {
        public Models.Netflix GetData()
        {
            var data = new Netflix.WebAPI.Models.Netflix();
            data.Id = 1002;
            data.UserId = 1004;

            return data;
        }
    }
}
