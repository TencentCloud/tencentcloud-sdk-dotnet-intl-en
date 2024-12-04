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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Number of instances returned per page. Default value: `20`. Maximum value: `1000`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Pagination offset, which is an integral multiple of `Limit`. Calculation formula:  `offset` = `limit` * (page number - 1).
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// ID of a specified instance,  such as  "crs-xjhsdj****" Log in to the [Redis console](https://console.cloud.tencent.com/redis) and copy the instance ID in the instance list.
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The instance list is sorted according to the following enumeration valid values:
        /// - projectId: By project ID.- createtime: By the creation time of instances.- instancename: By the name of instances.- type: By the type of instances.- curDeadline: By the expiration time of instances.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// For instance sorting order, the default is descending order.
        /// - 1: Descending order.
        /// - 0: Ascending order.
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// Array of VPC IDs such as 47525. If this parameter is not passed in or the array is empty, the classic network will be selected by default. This parameter is retained and can be ignored. It is set based on `UniqVpcIds` parameter format.
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// Array of VPC subnet IDs such as 56854. This parameter is retained and can be ignored. It is set based on `UniqSubnetIds` parameter format.
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Setting keywords field for fuzzy query, only instance names support fuzzy query.
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Array of project IDs
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Array of VPC IDs such as vpc-sad23jfdfk. If this parameter is not passed in or or the array is empty, the classic network will be selected by default.
        /// </summary>
        [JsonProperty("UniqVpcIds")]
        public string[] UniqVpcIds{ get; set; }

        /// <summary>
        /// Array of VPC subnet IDs such as subnet-fdj24n34j2
        /// </summary>
        [JsonProperty("UniqSubnetIds")]
        public string[] UniqSubnetIds{ get; set; }

        /// <summary>
        /// Array of region IDs (disused). The corresponding region can be queried through the common parameter `Region`.
        /// </summary>
        [JsonProperty("RegionIds")]
        public long?[] RegionIds{ get; set; }

        /// <summary>
        /// Instance status.
        /// - 0: To be initialized.
        /// - 1: In process.
        /// - 2: Running.
        /// - -2: Isolated.
        /// - -3: Pending Delete.
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// Instance architecture version.
        /// - 1: Single-node edition.
        /// - 2: Master-replica edition.- 3: Cluster edition.
        /// </summary>
        [JsonProperty("TypeVersion")]
        public long? TypeVersion{ get; set; }

        /// <summary>
        /// Storage engine information. Valid values: `Redis-2.8`, `Redis-4.0`, `Redis-5.0`, `Redis-6.0` or `CKV`.
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// Renewal pattern.
        /// - 0: Manual renewal.
        /// - 1: Automatic renewal.
        /// - 2: No renewal after expiry.
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long?[] AutoRenew{ get; set; }

        /// <summary>
        /// Billing mode. Only pay-as-you-go billing is supported.
        /// </summary>
        [JsonProperty("BillingMode")]
        public string BillingMode{ get; set; }

        /// <summary>
        /// Instance type.
        /// - 2: Redis 2.8 Memory Edition (standard architecture).
        /// - 3: CKV 3.2 Memory Edition (standard architecture).
        /// - 4: CKV 3.2 Memory Edition (cluster architecture).
        /// - 5: Redis 2.8 Memory Edition (stand-alone).
        /// - 6: Redis 4.0 Memory Edition (standard architecture).
        /// - 7: Redis 4.0 Memory Edition (cluster architecture).
        /// - 8: Redis 5.0 Memory Edition (standard architecture).
        /// - 9: Redis 5.0 Memory Edition (cluster architecture).
        /// - 15: Redis 6.2 Memory Edition (standard architecture).
        /// - 16: Redis 6.2 Memory Edition (cluster architecture).
        /// - 17: Redis 7.0 Memory Edition (standard architecture).
        /// - 18: Redis 7.0 Memory Edition (cluster architecture).
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// This parameter is of array type and supports the configuration of instance names, instance IDs, and IP addresses. Among these, the instance name is fuzzy matching while the instance ID and IP address are precise matching.
        /// - Each element in the array is used for a union-based matching query.- When both **InstanceId** and **SearchKeys** are configured simultaneously, their intersection will be used for the matching query.
        /// </summary>
        [JsonProperty("SearchKeys")]
        public string[] SearchKeys{ get; set; }

        /// <summary>
        /// Internal parameter, which can be ignored.
        /// </summary>
        [JsonProperty("TypeList")]
        public long?[] TypeList{ get; set; }

        /// <summary>
        /// Internal parameter, which can be ignored.
        /// </summary>
        [JsonProperty("MonitorVersion")]
        public string MonitorVersion{ get; set; }

        /// <summary>
        /// Resources filter by tag key and value. If this parameter is not specified or is an empty array, resources will not be filtered.
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTagInfo[] InstanceTags{ get; set; }

        /// <summary>
        /// Resources filter by tag key. If this parameter is not specified or is an empty array, resources will not be filtered.
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// The product version of the instance. If this parameter is not configured or the array is set to empty, instances will not be filtered based on this parameter by default.
        /// - local: local Disk Edition.- cdc: Cluster dedicated edition.
        /// </summary>
        [JsonProperty("ProductVersions")]
        public string[] ProductVersions{ get; set; }

        /// <summary>
        /// Batch query of the specified instances ID. The number of results returned is based on `Limit`.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Availability zone mode.
        /// - singleaz: Single availability zone.- multiaz: Multiple availability zones.
        /// </summary>
        [JsonProperty("AzMode")]
        public string AzMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "UniqVpcIds.", this.UniqVpcIds);
            this.SetParamArraySimple(map, prefix + "UniqSubnetIds.", this.UniqSubnetIds);
            this.SetParamArraySimple(map, prefix + "RegionIds.", this.RegionIds);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "TypeVersion", this.TypeVersion);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamArraySimple(map, prefix + "AutoRenew.", this.AutoRenew);
            this.SetParamSimple(map, prefix + "BillingMode", this.BillingMode);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "SearchKeys.", this.SearchKeys);
            this.SetParamArraySimple(map, prefix + "TypeList.", this.TypeList);
            this.SetParamSimple(map, prefix + "MonitorVersion", this.MonitorVersion);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamArraySimple(map, prefix + "ProductVersions.", this.ProductVersions);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "AzMode", this.AzMode);
        }
    }
}

