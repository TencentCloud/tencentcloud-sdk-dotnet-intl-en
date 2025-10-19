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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID list. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Specifies the instance type for querying. Valid values:
        /// - 0: all instances.
        /// - 1: formal instance.
        /// - 2: temporary instance.
        /// - 3: read-only instance.
        /// - -1: the query range includes the formal, read-only, and disaster recovery instances simultaneously.
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// Specifies the cluster type of the instance to be queried. Valid values:
        /// - 0: replica set instance.
        /// - 1: sharded cluster instance.
        /// - -1: replica set and sharded cluster instance.
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// Specifies the current status of the instance to be queried. Valid values:
        /// - 0: to be initialized.
        /// - 1: processing, such as specification changes and parameter modifications.
        /// - 2: running normally.
        /// - -2: isolated (yearly/monthly subscription).
        /// - -3: isolated (pay-as-you-go).
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// VPC ID.
        ///  - You do not need to specify this parameter for basic networks.
        ///  - Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/MongoDB), click a VPC name in the instance list, and obtain the ID on the **VPC** page.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// VPC subnet ID.
        ///  - You do not need to specify this parameter for basic networks.
        ///  - Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/MongoDB), click a VPC name in the instance list, and obtain the subnet ID on the **VPC** page.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Billing type. Valid value: 0 (pay-as-you-go)
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Number of entries returned per request. The default value is 20, and the value range is (1, 100].
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Configures the field for sorting returned results. Currently, "ProjectId", "InstanceName", and "CreateTime" are supported for sorting.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Configures the method for sorting returned results.
        ///  - ASC: ascending order.
        ///  - DESC: descending order.
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }

        /// <summary>
        /// Project ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/MongoDB) and select Project Management in the account information drop-down menu at the top right corner to query projects.
        /// </summary>
        [JsonProperty("ProjectIds")]
        public ulong?[] ProjectIds{ get; set; }

        /// <summary>
        /// Specifies the keyword for search. Specific instance IDs, instance names, or private IP addresses are supported.
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Tag information, including the tag key and tag value.
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

