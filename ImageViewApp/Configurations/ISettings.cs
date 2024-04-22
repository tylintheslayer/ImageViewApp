﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewApp.Configuration
{
    public interface ISettings
    {
        public string AzureSearchEndPoint { get; }
        public string AzureSearchKey { get; }
        public string AzureOpenAiEndPoint { get; }
        public string AzureOpenAiKey { get; }

    }

}