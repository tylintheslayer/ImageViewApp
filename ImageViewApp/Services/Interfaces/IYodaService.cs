﻿using Azure.AI.OpenAI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageViewApp.Services.Interfaces
{
    public interface IYodaService
    {
        Task<ChatMessage> GetCompletion();
    }
}