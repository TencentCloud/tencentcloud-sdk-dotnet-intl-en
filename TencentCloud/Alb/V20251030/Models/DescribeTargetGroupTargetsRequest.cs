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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTargetGroupTargetsRequest : AbstractModel
    {
        
        /// <summary>
        /// Target group ID. The format is `lbtg-` followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("TargetGroupId")]
        public string TargetGroupId{ get; set; }

        /// <summary>
        /// Filter. Query backend services by specified filter criteria. Supported values:
        /// - The value of Name is **TargetId**. Filter backend services by resource ID. This parameter is valid only when the backend type of the target group is **Instance**. The value of Values is the resource ID of Cvm or Eni.
        /// -The value of `Name` is **TargetIp**. Filter backend services by resource IP. This parameter is valid only when the backend type of the target group is **Ip**. The value of `Values` is the IP of the backend service.
        /// -Filter by tag.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The number of return lists, with a default value of **20** and a maximum value of **100**.
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// Token for the next query. Not required for the first query or when there are no more queries.
        /// If there is a next query, the value is the NextToken value returned from the last API call.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupId", this.TargetGroupId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

