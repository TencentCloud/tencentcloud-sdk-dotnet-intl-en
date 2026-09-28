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

    public class DescribeTargetGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter. Query backend services by specified filter criteria. Supported values:
        /// - The value of Name is **VpcId**. Filter target groups by VPC instance. The value of **Values** is a unique VPC ID list.
        /// -The value of `Name` is **TargetType**. Filter target groups by backend service type. The value of `Values` can be **Instance**.
        /// -The value of `Name` is **TargetGroupName**. Filter target groups by target group name. The value of `Values` is a list of target group names.
        /// - The value of `Name` is **Protocol**. Filter target groups by the backend service protocol of the target group. The value of `Values` is a list of backend service protocols of target groups.
        /// -Filter by tag.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Number of returned entries. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// Token for the next query. Not required for the first query or when there are no more queries.
        /// If there is a next query, the value is the NextToken value returned from the last API call.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Target group ID list. The ID format is `lbtg-` followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("TargetGroupIds")]
        public string[] TargetGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArraySimple(map, prefix + "TargetGroupIds.", this.TargetGroupIds);
        }
    }
}

