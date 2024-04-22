using ImageViewApp.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewApp.Configuration
{
    public class ConstantSettings : ISettings
    {
        public string AzureOpenAiEndPoint { get => "https://yodaopenai.openai.azure.com/"; }
        public string AzureOpenAiKey { get => "272b5b3a7ccf4d0f9f9566942d4e262c"; }
    }
}