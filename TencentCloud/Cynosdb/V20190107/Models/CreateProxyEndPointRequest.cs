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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateProxyEndPointRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// VPC ID. By default, it remains consistent with the VPC ID of the cluster.
        /// </summary>
        [JsonProperty("UniqueVpcId")]
        public string UniqueVpcId{ get; set; }

        /// <summary>
        /// Subnet ID of the VPC. By default, it remains consistent with the subnet ID of the cluster.
        /// </summary>
        [JsonProperty("UniqueSubnetId")]
        public string UniqueSubnetId{ get; set; }

        /// <summary>
        /// Type of connection pool: SessionConnectionPool (session-level connection pool).
        /// </summary>
        [JsonProperty("ConnectionPoolType")]
        public string ConnectionPoolType{ get; set; }

        /// <summary>
        /// Whether to enable the connection pool.
        /// yes: indicates enabled.
        /// no: indicates not enabled.
        /// </summary>
        [JsonProperty("OpenConnectionPool")]
        public string OpenConnectionPool{ get; set; }

        /// <summary>
        /// Threshold of the connection pool: unit (seconds). Valid values: 0 - 300 seconds.
        /// </summary>
        [JsonProperty("ConnectionPoolTimeOut")]
        public long? ConnectionPoolTimeOut{ get; set; }

        /// <summary>
        /// Array of bound security group IDs.
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The vip information to be bound must correspond to the UniqueVpcId.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// Weight mode:
        /// system: system-assigned.
        /// custom: custom.
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// Whether to automatically add a read-only instance.
        /// yes: indicates automatically adding a read-only instance.
        /// no: indicates not to automatically add a read-only instance.
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public string AutoAddRo{ get; set; }

        /// <summary>
        /// Whether to enable failover.
        /// yes: indicates enabled. After it is enabled, when the database proxy encounters faults, the connection address will be routed to the primary instance.
        /// no: indicates not enabled.
        /// Description:
        /// Only when the value of the RwType parameter is READWRITE can this option be configured.
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// Consistency Type:
        /// eventual: eventual consistency.
        /// global: global consistency.
        /// session: session consistency.
        /// Description:
        /// Only when the RwType parameter value is READWRITE can this option be configured.
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public string ConsistencyType{ get; set; }

        /// <summary>
        /// Read-Write Attribute:
        /// READWRITE: indicates read/write splitting. Only when this parameter value is READWRITE can the FailOver and ConsistencyType parameters be configured.
        /// READONLY: indicates read-only.
        /// </summary>
        [JsonProperty("RwType")]
        public string RwType{ get; set; }

        /// <summary>
        /// The consistency timeout period. Value range: 0 - 1000000 (microseconds). When set to 0, if a read-only instance experiences latency causing the consistency policy to be unsatisfied, the request will wait indefinitely.
        /// </summary>
        [JsonProperty("ConsistencyTimeOut")]
        public long? ConsistencyTimeOut{ get; set; }

        /// <summary>
        /// Whether to enable transaction split. After it is enabled, read and write operations in a transaction are split to different instances for execution.
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// Access mode:
        /// nearby: nearby access.
        /// balance: balanced allocation.
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// Instance weight.
        /// </summary>
        [JsonProperty("InstanceWeights")]
        public ProxyInstanceWeight[] InstanceWeights{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "UniqueVpcId", this.UniqueVpcId);
            this.SetParamSimple(map, prefix + "UniqueSubnetId", this.UniqueSubnetId);
            this.SetParamSimple(map, prefix + "ConnectionPoolType", this.ConnectionPoolType);
            this.SetParamSimple(map, prefix + "OpenConnectionPool", this.OpenConnectionPool);
            this.SetParamSimple(map, prefix + "ConnectionPoolTimeOut", this.ConnectionPoolTimeOut);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "RwType", this.RwType);
            this.SetParamSimple(map, prefix + "ConsistencyTimeOut", this.ConsistencyTimeOut);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamArrayObj(map, prefix + "InstanceWeights.", this.InstanceWeights);
        }
    }
}

