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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCustomizedConfigListRequest : AbstractModel
    {
        
        /// <summary>
        /// Configuration type. Valid values: `CLB` (CLB-specific configs), `SERVER` (domain name-specific configs), and `LOCATION` (forwarding rule-specific configs).
        /// </summary>
        [JsonProperty("ConfigType")]
        public string ConfigType{ get; set; }

        /// <summary>
        /// Pagination offset. defaults to 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results. default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Specifies the name of configs to query. Fuzzy match is supported.
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// Configuration ID, can be accessed through the [DescribeCustomizedConfigList](https://www.tencentcloud.comom/document/api/214/60009?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("UconfigIds")]
        public string[] UconfigIds{ get; set; }

        /// <summary>
        /// Filter criteria as follows:.
        /// - loadbalancer-id
        /// Filter by [cloud load balancer ID]. instance billing mode such as lb-9vxezxza.
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1).
        /// - vip
        /// Filter by [clb VIP]. network billing mode such as "1.1.1.1", "2204::22:3".
        /// Type: String.
        /// Required: No
        /// Method for obtaining: [DescribeLoadBalancers](https://www.tencentcloud.comom/document/product/1108/48459?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigType", this.ConfigType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamArraySimple(map, prefix + "UconfigIds.", this.UconfigIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

