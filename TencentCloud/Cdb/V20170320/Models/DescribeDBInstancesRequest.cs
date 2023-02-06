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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Instance type. Value range: 1 (primary), 2 (disaster recovery), 3 (read-only).
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public ulong?[] InstanceTypes{ get; set; }

        /// <summary>
        /// Private IP address of the instance.
        /// </summary>
        [JsonProperty("Vips")]
        public string[] Vips{ get; set; }

        /// <summary>
        /// Instance status. Value range: <br>0 - creating <br>1 - running <br>4 - isolating <br>5 - isolated (the instance can be restored and started in the recycle bin)
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }

        /// <summary>
        /// Offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned for a single request. Default value: 20. Maximum value: 2,000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Security group ID. When it is used as a filter, the `WithSecurityGroup` parameter should be set to 1.
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// Billing method. Value range: 0 (monthly subscribed), 1 (hourly).
        /// </summary>
        [JsonProperty("PayTypes")]
        public ulong?[] PayTypes{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// Instance task status. Valid values: <br>0 - no task <br>1 - upgrading <br>2 - importing data <br>3 - enabling secondary instance access <br>4 - enabling public network access <br>5 - batch operation in progress <br>6 - rolling back <br>7 - disabling public network access <br>8 - modifying password <br>9 - renaming instance <br>10 - restarting <br>12 - migrating self-built database <br>13 - dropping tables <br>14 - Disaster recovery instance creating sync task <br>15 - waiting for switch <br>16 - switching <br>17 - upgrade and switch completed <br>19 - parameter settings to be executed
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong?[] TaskStatus{ get; set; }

        /// <summary>
        /// Version of the instance database engine. Value range: 5.1, 5.5, 5.6, 5.7.
        /// </summary>
        [JsonProperty("EngineVersions")]
        public string[] EngineVersions{ get; set; }

        /// <summary>
        /// VPC ID.
        /// </summary>
        [JsonProperty("VpcIds")]
        public ulong?[] VpcIds{ get; set; }

        /// <summary>
        /// AZ ID.
        /// </summary>
        [JsonProperty("ZoneIds")]
        public ulong?[] ZoneIds{ get; set; }

        /// <summary>
        /// Subnet ID.
        /// </summary>
        [JsonProperty("SubnetIds")]
        public ulong?[] SubnetIds{ get; set; }

        /// <summary>
        /// Whether to lock disk write. Valid values: `0`(unlock), `1`(lock). Default value: 0.
        /// </summary>
        [JsonProperty("CdbErrors")]
        public long?[] CdbErrors{ get; set; }

        /// <summary>
        /// Sort by field of the returned result set. Currently, supported values include "InstanceId", "InstanceName", "CreateTime", and "DeadlineTime".
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// Sorting method of the returned result set. Currently, "ASC" or "DESC" is supported.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// Whether security group ID is used as a filter
        /// </summary>
        [JsonProperty("WithSecurityGroup")]
        public long? WithSecurityGroup{ get; set; }

        /// <summary>
        /// Whether dedicated cluster details are included. Value range: 0 (not included), 1 (included)
        /// </summary>
        [JsonProperty("WithExCluster")]
        public long? WithExCluster{ get; set; }

        /// <summary>
        /// Exclusive cluster ID.
        /// </summary>
        [JsonProperty("ExClusterId")]
        public string ExClusterId{ get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Initialization flag. Value range: 0 (not initialized), 1 (initialized).
        /// </summary>
        [JsonProperty("InitFlag")]
        public long? InitFlag{ get; set; }

        /// <summary>
        /// Whether instances corresponding to the disaster recovery relationship are included. Valid values: 0 (not included), 1 (included). Default value: 1. If a primary instance is pulled, the data of the disaster recovery relationship will be in the `DrInfo` field. If a disaster recovery instance is pulled, the data of the disaster recovery relationship will be in the `MasterInfo` field. The disaster recovery relationship contains only partial basic data. To get the detailed data, you need to call an API to pull it.
        /// </summary>
        [JsonProperty("WithDr")]
        public long? WithDr{ get; set; }

        /// <summary>
        /// Whether read-only instances are included. Valid values: 0 (not included), 1 (included). Default value: 1.
        /// </summary>
        [JsonProperty("WithRo")]
        public long? WithRo{ get; set; }

        /// <summary>
        /// Whether primary instances are included. Valid values: 0 (not included), 1 (included). Default value: 1.
        /// </summary>
        [JsonProperty("WithMaster")]
        public long? WithMaster{ get; set; }

        /// <summary>
        /// Placement group ID list.
        /// </summary>
        [JsonProperty("DeployGroupIds")]
        public string[] DeployGroupIds{ get; set; }

        /// <summary>
        /// Whether to use the tag key as a filter condition
        /// </summary>
        [JsonProperty("TagKeysForSearch")]
        public string[] TagKeysForSearch{ get; set; }

        /// <summary>
        /// Financial cage IDs.
        /// </summary>
        [JsonProperty("CageIds")]
        public string[] CageIds{ get; set; }

        /// <summary>
        /// Tag value
        /// </summary>
        [JsonProperty("TagValues")]
        public string[] TagValues{ get; set; }

        /// <summary>
        /// VPC character vpcId
        /// </summary>
        [JsonProperty("UniqueVpcIds")]
        public string[] UniqueVpcIds{ get; set; }

        /// <summary>
        /// VPC character subnetId
        /// </summary>
        [JsonProperty("UniqSubnetIds")]
        public string[] UniqSubnetIds{ get; set; }

        /// <summary>
        /// Tag key value
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Database proxy IP
        /// </summary>
        [JsonProperty("ProxyVips")]
        public string[] ProxyVips{ get; set; }

        /// <summary>
        /// Database proxy ID
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamArraySimple(map, prefix + "Vips.", this.Vips);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamArraySimple(map, prefix + "PayTypes.", this.PayTypes);
            this.SetParamArraySimple(map, prefix + "InstanceNames.", this.InstanceNames);
            this.SetParamArraySimple(map, prefix + "TaskStatus.", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "EngineVersions.", this.EngineVersions);
            this.SetParamArraySimple(map, prefix + "VpcIds.", this.VpcIds);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "CdbErrors.", this.CdbErrors);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamSimple(map, prefix + "WithSecurityGroup", this.WithSecurityGroup);
            this.SetParamSimple(map, prefix + "WithExCluster", this.WithExCluster);
            this.SetParamSimple(map, prefix + "ExClusterId", this.ExClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "InitFlag", this.InitFlag);
            this.SetParamSimple(map, prefix + "WithDr", this.WithDr);
            this.SetParamSimple(map, prefix + "WithRo", this.WithRo);
            this.SetParamSimple(map, prefix + "WithMaster", this.WithMaster);
            this.SetParamArraySimple(map, prefix + "DeployGroupIds.", this.DeployGroupIds);
            this.SetParamArraySimple(map, prefix + "TagKeysForSearch.", this.TagKeysForSearch);
            this.SetParamArraySimple(map, prefix + "CageIds.", this.CageIds);
            this.SetParamArraySimple(map, prefix + "TagValues.", this.TagValues);
            this.SetParamArraySimple(map, prefix + "UniqueVpcIds.", this.UniqueVpcIds);
            this.SetParamArraySimple(map, prefix + "UniqSubnetIds.", this.UniqSubnetIds);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "ProxyVips.", this.ProxyVips);
            this.SetParamArraySimple(map, prefix + "ProxyIds.", this.ProxyIds);
        }
    }
}

