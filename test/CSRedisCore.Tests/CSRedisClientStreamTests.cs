using CSRedis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CSRedisCore.Tests {
	public class CSRedisClientGeoTests : TestBase {

        /*
		 * 
		 * Stream 只有 redis-server 5.0+ 才提供，测试代码请连接高版本
		 * 
		 * */

        [Fact]
        public void XAdd()
        {
            var key = "mystream";
            ValueTuple<string, string>[] tup = new ValueTuple<string, string>[2];
            tup[0] = ("field1", "value1");
            tup[1] = ("field2", "value2");
            //rds.Set("tedt", "test");
            rds.XAdd(key, "42-0", tup);
        }

        private string GetUniqueKey(string type) => $"{type}_stream_{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}";
    }
}
