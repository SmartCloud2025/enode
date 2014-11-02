﻿using System;
using System.Collections.Generic;
using ENode.Eventing;

namespace ENode.EQueue
{
    [Serializable]
    public class EventMessage
    {
        public string CommandId { get; set; }
        public IEnumerable<IEvent> Events { get; set; }
        public IDictionary<string, string> Items { get; set; }

        public EventMessage()
        {
            Events = new List<IEvent>();
        }
    }
}
