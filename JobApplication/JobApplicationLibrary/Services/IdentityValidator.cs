﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplicationLibrary.Services
{
    public class IdentityValidator:IIdentityValidator
    {
        public string Country => throw new NotImplementedException();

        public ICountryDataProvider CountryDataProvider => throw new NotImplementedException();

        public ValidationMode ValidationMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsValid(string identityNumber)
        {
            return true;
        }

    }
}
