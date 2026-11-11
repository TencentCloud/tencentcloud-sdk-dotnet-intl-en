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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of instances output per page. Default parameter value: 20. Maximum value: 1000.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Pagination offset, which is an integer multiple of Limit. Calculation formula: offset=limit*(page number-1).</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Specifies the instance ID. Example: crs-xjhsdj****. Log in to the <a href="https://console.cloud.tencent.com/redis">Redis console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance list sorting criteria. Enumeration values are as follows:</p><ul><li>projectId: by project ID.</li><li>createtime: sort by instance creation time.</li><li>instancename: by instance name sorting.</li><li>type: by instance type.</li><li>curDeadline: by instance expiration time.</li></ul>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>Instance sorting order, with a default value of reverse sorting.</p><ul><li>1: Reverse order.</li><li>0: Sequential order.</li></ul>
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// <p>VPC ID array. If this parameter is not configured or the array is empty, the basic network is selected by default. For example: 47525. This parameter is temporarily reserved and can be ignored. Set the VPC ID array according to the format of the UniqVpcIds parameter.</p>
        /// </summary>
        [JsonProperty("VpcIds")]
        public string[] VpcIds{ get; set; }

        /// <summary>
        /// <p>Array of subnet IDs belonging to the private network, for example: 56854. This parameter is temporarily reserved and can be ignored. Set the private network subnet ID array according to the format of the UniqSubnetIds parameter.</p>
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// <p>Set the key field for fuzzy query. Only instance names support fuzzy query.</p>
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// <p>Array of project IDs.</p>
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>VPC ID array. If this parameter is not configured or the array is empty, the basic network is selected by default, for example: vpc-sad23jfdfk.</p>
        /// </summary>
        [JsonProperty("UniqVpcIds")]
        public string[] UniqVpcIds{ get; set; }

        /// <summary>
        /// <p>Subnet ID array belonging to the private network, for example: subnet-fdj24n34j2.</p>
        /// </summary>
        [JsonProperty("UniqSubnetIds")]
        public string[] UniqSubnetIds{ get; set; }

        /// <summary>
        /// <p>Region ID array. This parameter has been deprecated. Use the common parameter Region to query the corresponding region.</p>
        /// </summary>
        [JsonProperty("RegionIds")]
        public long?[] RegionIds{ get; set; }

        /// <summary>
        /// <p>Instance status.</p><ul><li>0: pending initialization.</li><li>1: in process.</li><li>2: running.</li><li>-2: isolated.</li><li>-3: pending deletion.</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long?[] Status{ get; set; }

        /// <summary>
        /// <p>Instance architecture version.</p><ul><li>1: standalone edition.</li><li>2: primary/secondary edition.</li><li>3: cluster version.</li></ul>
        /// </summary>
        [JsonProperty("TypeVersion")]
        public long? TypeVersion{ get; set; }

        /// <summary>
        /// <p>Storage engine info. It can be set to Redis-2.8, Redis-4.0, Redis-5.0, Redis-6.0, or CKV.</p>
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// <p>Renewal mode.</p><ul><li>0: Manual renewal.</li><li>1: Automatic renewal.</li><li>2: No renewal after expiry.</li></ul>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long?[] AutoRenew{ get; set; }

        /// <summary>
        /// <p>Billing mode.</p><ul><li>postpaid: pay-as-you-go billing.</li><li>prepaid: annual/monthly subscription.</li></ul>
        /// </summary>
        [JsonProperty("BillingMode")]
        public string BillingMode{ get; set; }

        /// <summary>
        /// <p>Instance type.</p><ul><li>2: Redis 2.8 memory edition (standard architecture).</li><li>3: CKV 3.2 memory edition (standard architecture).</li><li>4: CKV 3.2 memory edition (cluster architecture).</li><li>5: Redis 2.8 memory edition (standalone).</li><li>6: Redis 4.0 memory edition (standard architecture).</li><li>7: Redis 4.0 memory edition (cluster architecture).</li><li>8: Redis 5.0 memory edition (standard architecture).</li><li>9: Redis 5.0 memory edition (cluster architecture).</li><li>15: Redis 6.2 memory edition (standard architecture).</li><li>16: Redis 6.2 memory edition (cluster architecture).</li><li>17: Redis 7.0 memory edition (standard architecture).</li><li>18: Redis 7.0 memory edition (cluster architecture).</li><li>200: Memcached 1.6 memory edition (cluster architecture).</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>This parameter is an array type and supports configuring instance name, instance ID, and IP address. Among them, instance name uses fuzzy matching, while instance ID and IP address use exact matching.</p><ul><li>Each element in the array uses union for match query.</li><li>If <strong>InstanceId</strong> and <strong>SearchKeys</strong> are configured concurrently, their intersection is used for matching query.</li></ul>
        /// </summary>
        [JsonProperty("SearchKeys")]
        public string[] SearchKeys{ get; set; }

        /// <summary>
        /// <p>Internal parameter, which can be ignored.</p>
        /// </summary>
        [JsonProperty("TypeList")]
        public long?[] TypeList{ get; set; }

        /// <summary>
        /// <p>Internal parameter, which can be ignored.</p>
        /// </summary>
        [JsonProperty("MonitorVersion")]
        public string MonitorVersion{ get; set; }

        /// <summary>
        /// <p>Filter resources by tag Key and Value. If this parameter is not configured or the array is set to empty, no tag-based filtering is applied.</p>
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTagInfo[] InstanceTags{ get; set; }

        /// <summary>
        /// <p>Filter resources by tag Key. If this parameter is not configured or the array is set to empty, no filtering by tag Key is performed.</p>
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// <p>Deployment type of the instance. If this parameter is not configured or the array is set to empty, instances will not be filtered based on this parameter by default.</p><p>Enumeration values:</p><ul><li>local: Common I.</li><li>localv2: Common II.</li><li>cdc: Dedicated cluster.</li></ul>
        /// </summary>
        [JsonProperty("ProductVersions")]
        public string[] ProductVersions{ get; set; }

        /// <summary>
        /// <p>Batch query the specified instance IDs. The returned results are mainly limited by Limit.</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>Availability zone mode.</p><ul><li>singleaz: single availability zone.</li><li>multiaz: multi-availability zone.</li></ul>
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

