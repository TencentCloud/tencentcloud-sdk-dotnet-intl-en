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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeProxiesRequest : AbstractModel
    {
        
        /// <summary>
        /// Queries by one or multiple instance IDs. The upper limit on the number of instances for each request is 100. This parameter does not support specifying InstanceIds and Filters at the same time. It’s an old parameter, please switch to ProxyIds.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filters   
        /// The upper limit on Filters for each request is 10, and the upper limit on Filter.Values is 5. This parameter does not support specifying InstanceIds and Filters at the same time. 
        /// ProjectId - String - Required: No - Filter by a project ID.   
        /// AccessRegion - String - Required: No - Filter by an access region.    
        /// RealServerRegion - String - Required: No - Filter by an origin server region.
        /// GroupId - String - Required: No - Filter by a connection group ID.
        /// IPAddressVersion - String - Required: No - Filter by IP version.
        /// PackageType - String - Required: No - Filter by package type of connection groups.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Queries by one or multiple instance IDs. The upper limit on the number of instances for each request is 100. This parameter does not support specifying InstanceIds and Filters at the same time. It’s a new parameter, and replaces InstanceIds.
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// Tag list. If this field exists, the list of the resources with the tag will be pulled.
        /// It supports up to 5 tags. If there are two or more tags, the connections tagged any of them will be pulled.
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// When this field is 1, only not-grouped connections are pulled.
        /// When this field is 0, only grouped connections are pulled.
        /// When this field does not exist, all connections are pulled, including both not-grouped and grouped connections.
        /// </summary>
        [JsonProperty("Independent")]
        public long? Independent{ get; set; }

        /// <summary>
        /// Specifies how connections are listed. Valid values:
        /// `asc`: Ascending order
        /// `desc`: Descending order
        /// Default: `desc`
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// Sorting field. Valid values:
        /// `create_time`: Sort by creation time
        /// `proxy_id`: Sort by connection ID
        /// `bandwidth`:Sort by bandwidth limit
        /// `concurrent_connections`: Sort by number of concurrent connections
        /// Default: `create_time`
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "Independent", this.Independent);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
        }
    }
}

