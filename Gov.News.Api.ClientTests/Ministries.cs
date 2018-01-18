using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using System.Text;
using Newtonsoft.Json;
using System.Net;

namespace Gov.News.Api.ClientTests
{
    public class Ministry : ApiTestBase
    {
        /// <summary>
        /// Test GET Ministry
        /// </summary>
        [Fact]
        public async void Get()
        {
            var ministryList = await _client.Ministries.GetAllAsync(currentApiVersion);

            Assert.True(ministryList.Count > 0);
            String key = ministryList[0].Key;

            // get a single ministry.

            var ministry = await _client.Ministries.GetOneAsync(key, currentApiVersion);

            Assert.True(ministry != null);

            // get a minister.

            var minister = await _client.Ministries.GetMinisterAsync(key, currentApiVersion);
            Assert.True(minister != null);

        }
        

    }
}