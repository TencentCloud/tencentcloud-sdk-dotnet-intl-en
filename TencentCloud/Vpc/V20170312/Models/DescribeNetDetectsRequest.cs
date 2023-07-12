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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNetDetectsRequest : AbstractModel
    {
        
        /// <summary>
        /// The array of network probe IDs, such as [`netd-12345678`].
        /// </summary>
        [JsonProperty("NetDetectIds")]
        public string[] NetDetectIds{ get; set; }

        /// <summary>
        /// Filter conditions. `NetDetectIds` and `Filters` cannot be specified at the same time.
        /// <li>vpc-id - String - (Filter condition) The VPC instance ID, such as vpc-12345678.</li>
        /// <li>net-detect-id - String - (Filter condition) The network detection instance ID, such as netd-12345678.</li>
        /// <li>subnet-id - String - (Filter condition) The subnet instance ID, such as subnet-12345678.</li>
        /// <li>net-detect-name - String - (Filter condition) The network detection name.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The offset. Default: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The number of returned values. Default: 20. Maximum: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetDetectIds.", this.NetDetectIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

