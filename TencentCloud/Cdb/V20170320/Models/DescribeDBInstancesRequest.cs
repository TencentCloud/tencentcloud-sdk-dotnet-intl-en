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
        /// <p>Instance type. Valid values: 1 - Primary instance, 2 - Disaster recovery instance, 3 - Read-only instance.</p>
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public ulong?[] InstanceTypes{ get; set; }

        /// <summary>
        /// <p>Private IP address of the instance.</p>
        /// </summary>
        [JsonProperty("Vips")]
        public string[] Vips{ get; set; }

        /// <summary>
        /// <p>Instance status. Valid values:<br>0 - Creating<br>1 - Running<br>4 - Isolation operation in progress<br>5 - Isolated (can be restored from the Recycle Bin)</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }

        /// <summary>
        /// <p>Offset. Default value is 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Number of items returned per request. Default value: 20. Maximum value: 2000.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Security group ID. When using security group ID as the filter condition, the WithSecurityGroup parameter needs to be specified as 1.</p>
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// <p>Payment type. Valid values: 0 - yearly/monthly subscription; 1 - bill by hour.</p>
        /// </summary>
        [JsonProperty("PayTypes")]
        public ulong?[] PayTypes{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// <p>Instance task status, possible values:<br>0 - No tasks<br>1 - Upgrading<br>2 - Data import in progress<br>3 - Enabling Slave<br>4 - Enabling public network access<br>5 - Batch operation in progress<br>6 - Rolling back<br>7 - Disabling public network access<br>8 - Password change in progress<br>9 - Renaming instance<br>10 - Restarting<br>12 - Self-built migration in progress<br>13 - Deleting database table<br>14 - Disaster recovery instance creation sync in progress<br>15 - Upgrade pending switch<br>16 - Upgrade and switch in progress<br>17 - Switch completed<br>19 - Parameter setting pending execution<br>34 - Node in-place upgrade to be executed</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong?[] TaskStatus{ get; set; }

        /// <summary>
        /// <p>Database engine version of the instance. Possible values: 5.1, 5.5, 5.6, and 5.7.</p>
        /// </summary>
        [JsonProperty("EngineVersions")]
        public string[] EngineVersions{ get; set; }

        /// <summary>
        /// <p>VPC ID.</p>
        /// </summary>
        [JsonProperty("VpcIds")]
        public ulong?[] VpcIds{ get; set; }

        /// <summary>
        /// <p>Availability zone ID.</p>
        /// </summary>
        [JsonProperty("ZoneIds")]
        public ulong?[] ZoneIds{ get; set; }

        /// <summary>
        /// <p>Subnet ID.</p>
        /// </summary>
        [JsonProperty("SubnetIds")]
        public ulong?[] SubnetIds{ get; set; }

        /// <summary>
        /// <p>Whether to set the lock flag. Available values: 0 - not lock, 1 - lock. Default is 0.</p>
        /// </summary>
        [JsonProperty("CdbErrors")]
        public long?[] CdbErrors{ get; set; }

        /// <summary>
        /// <p>Sorting field of the returned result set. Currently supports: "instanceId", "instanceName", "createTime", and "deadlineTime".</p>
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// <p>Sorting method of the returned result set. Valid values: "ASC" - ascending order; "DESC" - descending order. The default is "DESC".</p>
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// <p>Whether to use security group ID as the filter condition.<br>Description: 0 indicates no, 1 indicates yes.</p>
        /// </summary>
        [JsonProperty("WithSecurityGroup")]
        public long? WithSecurityGroup{ get; set; }

        /// <summary>
        /// <p>Whether the exclusive cluster detail is included. Value range: 0 - not contained, 1 - contained.</p>
        /// </summary>
        [JsonProperty("WithExCluster")]
        public long? WithExCluster{ get; set; }

        /// <summary>
        /// <p>Dedicated cluster ID.</p>
        /// </summary>
        [JsonProperty("ExClusterId")]
        public string ExClusterId{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// <p>Initialization flag. Valid values: 0 - uninitialized, 1 - initialized.</p>
        /// </summary>
        [JsonProperty("InitFlag")]
        public long? InitFlag{ get; set; }

        /// <summary>
        /// <p>Whether the corresponding instance in the disaster recovery relationship is included. Valid values: 0 - excluding, 1 - included. Default value: 1. If pulling the primary instance, the data of the disaster recovery relationship is in the DrInfo field. If pulling the disaster recovery instance, the data of the disaster recovery relationship is in the MasterInfo field. The disaster recovery relationship only contains partial basic data. Detailed data must be pulled manually via the interface.</p>
        /// </summary>
        [JsonProperty("WithDr")]
        public long? WithDr{ get; set; }

        /// <summary>
        /// <p>Whether it contains read-only instances. Valid values: 0 - does not include, 1 - includes. Default value is 1.</p>
        /// </summary>
        [JsonProperty("WithRo")]
        public long? WithRo{ get; set; }

        /// <summary>
        /// <p>Whether the primary instance is included. Valid values: 0 - does not include, 1 - includes. Default value is 1.</p>
        /// </summary>
        [JsonProperty("WithMaster")]
        public long? WithMaster{ get; set; }

        /// <summary>
        /// <p>Placement group ID list.</p>
        /// </summary>
        [JsonProperty("DeployGroupIds")]
        public string[] DeployGroupIds{ get; set; }

        /// <summary>
        /// <p>Filter by tag key.</p>
        /// </summary>
        [JsonProperty("TagKeysForSearch")]
        public string[] TagKeysForSearch{ get; set; }

        /// <summary>
        /// <p>Financial Enclosure ID.</p>
        /// </summary>
        [JsonProperty("CageIds")]
        public string[] CageIds{ get; set; }

        /// <summary>
        /// <p>Tag value</p>
        /// </summary>
        [JsonProperty("TagValues")]
        public string[] TagValues{ get; set; }

        /// <summary>
        /// <p>Character type VPC ID</p>
        /// </summary>
        [JsonProperty("UniqueVpcIds")]
        public string[] UniqueVpcIds{ get; set; }

        /// <summary>
        /// <p>VPC character type subnetId</p>
        /// </summary>
        [JsonProperty("UniqSubnetIds")]
        public string[] UniqSubnetIds{ get; set; }

        /// <summary>
        /// <p>Tag key value<br>Please note, tags of the instance being created are unable to query.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Database proxy IP.</p>
        /// </summary>
        [JsonProperty("ProxyVips")]
        public string[] ProxyVips{ get; set; }

        /// <summary>
        /// <p>Database proxy ID.</p>
        /// </summary>
        [JsonProperty("ProxyIds")]
        public string[] ProxyIds{ get; set; }

        /// <summary>
        /// <p>Database engine type. Valid values: InnoDB, RocksDB.</p>
        /// </summary>
        [JsonProperty("EngineTypes")]
        public string[] EngineTypes{ get; set; }

        /// <summary>
        /// <p>Whether to obtain the Cluster Edition instance node information. Valid values: true or false. The default value is false.</p>
        /// </summary>
        [JsonProperty("QueryClusterInfo")]
        public bool? QueryClusterInfo{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "EngineTypes.", this.EngineTypes);
            this.SetParamSimple(map, prefix + "QueryClusterInfo", this.QueryClusterInfo);
        }
    }
}

