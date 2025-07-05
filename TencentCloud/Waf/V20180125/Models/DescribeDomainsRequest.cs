/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// Paging offset, a multiple of limit. The minimum value is 0, and the maximum value is Total/Limit rounded up.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned domains
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter array. The filter fields are as follows. Edition: instance version, which can be set to sparta-waf or clb-waf; Domain: domain name; DomainId: domain name ID; InstanceName: instance name; InstanceId: instance ID; FlowMode: traffic access mode, which supports only CLB WAF; FlowCheckMode: traffic inspection mode, which supports only CLB WAF; ClsStatus: log switch; Status: WAF switch; BotStatus: BOT switch; ApiStatus: API security switch; Engine: engine mode; UpstreamIP: origin server IP address, which supports only SaaS WAF; UpstreamDomain: origin server domain name, which supports only SaaS WAF; DomainState: domain name status, which supports only SaaS WAF; SgState: security group status, which supports only SaaS WAF; Label: group tag, which supports the filtering of only one tag at a time.
        /// </summary>
        [JsonProperty("Filters")]
        public FiltersItemNew[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

