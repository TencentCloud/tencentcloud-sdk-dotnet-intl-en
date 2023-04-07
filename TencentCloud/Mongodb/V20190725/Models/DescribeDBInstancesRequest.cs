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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// List of instance IDs in the format of cmgo-p8vnipr5. It is the same as the instance ID displayed on the TencentDB console page.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Instance type. Valid values: <ul><li>`0`: All instances. </li><li>`1`: Regular instances. </li><li>`2`: Temp instances. </li><li>`3`: Read-only instances. </li><li>`-1`: Regular instances, read-only instances, disaster recovery instances.</li></ul>
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// Cluster type. Valid values: <ul><li>`0`: Replica set instances. </li><li>`1`: Sharded cluster instances. </li><li>`-1`: All instances.</li></ul>
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// Instance status. Valid values: <ul><li>`0`: To be initialized. </li><li>`1`: In process. </li><li>`2`: Valid. </li><li>`-2`: Isolated (for monthly subscribed instances). </li><li>`-3`: Isolated (for pay-as-you-go instances).</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// VPC ID. This parameter can be left empty for the classic network.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID of VPC. This parameter can be left empty for the classic network. If it is passed in as an input parameter, the corresponding VpcId must be set.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Billing type. Valid value: 0 (pay-as-you-go)
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Number of results returned per request. Default value: `20`. Value range: [1,100].
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Sort by field of the returned result set. Valid values: `ProjectId`, `InstanceName`, `CreateTime`. The return results are sorted in ascending order by default.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting method of the return result set. Valid values: `ASC`, `DESC`.
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectIds")]
        public ulong?[] ProjectIds{ get; set; }

        /// <summary>
        /// Search keyword, which can be instance ID, instance name, or complete IP.
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Tag information
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

