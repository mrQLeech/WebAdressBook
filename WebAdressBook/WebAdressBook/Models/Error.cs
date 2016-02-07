using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdressBook.Models
{
    public class Error
    {
        private string _errorMessage;
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
        }

        public Error(string message)
        {
            _errorMessage = message;
        }
    }
}