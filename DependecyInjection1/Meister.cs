﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection1
{
  internal class Meister
  {
    private Lehrling lehrling;
    public Meister()
    {
      lehrling = new Lehrling();
    }
    public void GibAnweisung()
    {
      lehrling.GrabMalEinloch();
    }
  }
}
