﻿using Chain_of_Responsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Director
    {
        public BaseHandler<DialogContext> GetApplicationChain()
        {
            var mainHandler = new ApplicationHandler();

            mainHandler.SetNext(new AnsweringMachineHandler());

            return mainHandler;
        }
    }
}