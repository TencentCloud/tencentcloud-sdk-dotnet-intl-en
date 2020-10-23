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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGroupDomainConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Nearest access configuration list of domain name resolution.
        /// </summary>
        [JsonProperty("AccessRegionList")]
        public DomainAccessRegionDict[] AccessRegionList{ get; set; }

        /// <summary>
        /// Default accesses Ip.
        /// </summary>
        [JsonProperty("DefaultDnsIp")]
        public string DefaultDnsIp{ get; set; }

        /// <summary>
        /// Connection group ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Total number of configuration of access regions.
        /// </summary>
        [JsonProperty("AccessRegionCount")]
        public long? AccessRegionCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "AccessRegionList.", this.AccessRegionList);
            this.SetParamSimple(map, prefix + "DefaultDnsIp", this.DefaultDnsIp);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "AccessRegionCount", this.AccessRegionCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

