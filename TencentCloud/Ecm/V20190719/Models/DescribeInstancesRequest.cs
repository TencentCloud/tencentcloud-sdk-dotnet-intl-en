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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter.
        /// zone      String      Required: no     (Filter) Filter by AZ abbreviation.
        /// zone-name      String      Required: no     (Filter) Filter by AZ name. Fuzzy match is supported.
        /// module-id      String      Required: no     (Filter) Filter by module ID.
        /// instance-id      String      Required: no      (Filter) Filter by instance ID.
        /// instance-name      String      Required: no      (Filter) Filter by instance name. Fuzzy match is supported.
        /// ip-address      String      Required: no      (Filter) Filter by the instance's private/public IP.
        /// instance-uuid   string Required: no (Filter) Filter instances by `uuid`.
        /// instance-state  string  Required: no (Filter) Update instances by instance status.
        /// internet-service-provider      String      Required: no      (Filter) Filter by the ISP of the instance's public IP.
        /// tag-key      String      Required: no      (Filter) Filter by tag key.
        /// tag:tag-key      String      Required: no      (Filter) Filter by tag key-value pair. Replace `tag-key` with the specific tag key.
        /// instance-family      String      Required: no      (Filter) Filter by model family.
        /// module-name      String      Required: no      (Filter) Filter by module name. Fuzzy match is supported.
        /// image-id      String      Required: no      (Filter) Filter by instance image ID.
        /// vpc-id String      Required: no      (Filter) Filter by instance VPC ID.
        /// subnet-id String      Required: no      (Filter) Filter by instance subnet ID.
        /// 
        /// If the `Filters` parameter is not specified, the information of all relevant instances will be queried.
        /// Each request can contain up to 5 `Filter.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20 (if the number of query results is greater than or equal to 20). Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Specified sort by field. Currently, valid values are as follows:
        /// timestamp: sort by instance creation time.
        /// Note: you can sort only by creation time currently. More sort criteria may be supported in the future.
        /// If this parameter is not specified, instances will be sorted by creation time by default.
        /// </summary>
        [JsonProperty("OrderByField")]
        public string OrderByField{ get; set; }

        /// <summary>
        /// Sorting order. 0: descending; 1: ascending. If this parameter is not specified, it will be descending by default.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public long? OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderByField", this.OrderByField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

