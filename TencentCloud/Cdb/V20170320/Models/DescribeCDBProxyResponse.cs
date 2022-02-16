/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCDBProxyResponse : AbstractModel
    {
        
        /// <summary>
        /// Basic information of the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("BaseGroup")]
        public BaseGroupInfo BaseGroup{ get; set; }

        /// <summary>
        /// Address information of the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("Address")]
        public Address Address{ get; set; }

        /// <summary>
        /// Node information of the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("ProxyNode")]
        public ProxyNodeInfo ProxyNode{ get; set; }

        /// <summary>
        /// Read/Write separation information
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("RWInstInfo")]
        public RWInfo RWInstInfo{ get; set; }

        /// <summary>
        /// Connection pool information
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("ConnectionPoolInfo")]
        public ConnectionPoolInfo ConnectionPoolInfo{ get; set; }

        /// <summary>
        /// Number of instances in the proxy group
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Proxy information
        /// Note: this field may return `null`, indicating that no valid value can be found.
        /// </summary>
        [JsonProperty("ProxyGroup")]
        public ProxyGroup[] ProxyGroup{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BaseGroup.", this.BaseGroup);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamObj(map, prefix + "ProxyNode.", this.ProxyNode);
            this.SetParamObj(map, prefix + "RWInstInfo.", this.RWInstInfo);
            this.SetParamObj(map, prefix + "ConnectionPoolInfo.", this.ConnectionPoolInfo);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArrayObj(map, prefix + "ProxyGroup.", this.ProxyGroup);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

