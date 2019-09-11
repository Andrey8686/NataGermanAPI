using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using NG.Core.Models;

namespace NG.Core.Managers
{
    public class ErrorManager
    {
        private List<string> _erroList;

        public ErrorManager()
        {
            _erroList = new List<string>();
        }

        public void SetError(string err)
        {
            _erroList.Add(err);
        }

        public void SetError(List<string> err)
        {
            _erroList.AddRange(err);
        }

        public string GetErrors()
        {
            return JsonConvert.SerializeObject(new { ErrorList = _erroList });
        }

        public bool IsErrors()
        {
            return _erroList.Any();
        }

       
        









    }
}
