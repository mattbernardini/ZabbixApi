﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Rhino.Mocks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZabbixApi.Entities;
using ZabbixApi.Services;
using ZabbixApi;

namespace ZabbixApi.Test
{
    [TestClass]
    public class EventServiceUnitTest
    {
        JsonSerializerSettings _settings;
        IContext _context;

        public EventServiceUnitTest()
        {
            _settings = new JsonSerializerSettings();
            _settings.Converters = new JsonConverter[] { new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter() }; ;
            _settings.NullValueHandling = NullValueHandling.Ignore;
        }


        [TestInitialize]
        public void Initialize()
        {
            _context = MockRepository.GenerateStub<IContext>();
        }

        [TestMethod]
        public void GetHost_SomeName_SomeHost()
        {
            //var data = JsonConvert.DeserializeObject<Event[]>(File.ReadAllText(_hostGet), _settings);

            //_context.Stub(x => x.SendRequest<Event[]>(Arg<object>.Is.Anything, Arg<string>.Is.Anything)).Return(data);

            var target = new EventService(_context) as IEventService;
            
            var result = target.Get();

        }
    }
}
