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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of instance IDs. The maximum number of instances in each request is 100. You can obtain the instance IDs from the `InstanceId` field in the response of the [DescribeInstances](https://www.tencentcloud.com/document/api/1207/47573?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// List of filters.
        /// <li>instance-name</li>Filters by instance name.
        /// Type: String
        /// Required: No
        /// <li>private-ip-address</li>Filters by the private IP of the primary ENI of the instance.
        /// Type: String
        /// Required: No
        /// <li>public-ip-address</li>Filters by the public IP of the primary ENI of the instance.
        /// Type: String
        /// Required: No
        /// <li>zone</li>Filters by AZ.
        /// Type: String
        /// Required: No
        /// <li>instance-state</li>Filters by instance state.
        /// Type: String
        /// Required: No
        /// <li>tag-key</li>Filters by tag key.
        /// Type: String
        /// Required: No
        /// <li>tag-value</li>Filters by tag value.
        /// Type: String
        /// Required: No
        /// <li> tag:tag-key</li>Filters by tag key-value pair. Replace tag-key with the specific tag key.
        /// Type: String
        /// Required: No
        /// <li>bundle-id</li>Filters by bundle ID.
        /// Type: String
        /// Required: No
        /// 
        /// The maximum number of Filters per request is 10, and the maximum number of Filter.Values is 100. You cannot specify both InstanceIds and Filters at the same time.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset. Default value: 0. For more information on `Offset`, see the relevant section in the API [Introduction](https://www.tencentcloud.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant section in the API [Introduction](https://www.tencentcloud.com/document/product/1207/47578?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Specifies the field by which to sort. Valid values: "EXPIRED_TIME": Sorts by the expiration time of the instance. 
        ///  If this field is not passed in, instances with the status of "pending reclamation" are returned first, and the remaining instances are returned in descending order by creation time.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// The order in which the output instance list is sorted. Valid values:
        /// "ASC": Sorts in ascending order.
        /// "DESC": Sorts in descending order.
        /// By default, the list is sorted in ascending order. If this field is passed in, OrderField must be specified.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

