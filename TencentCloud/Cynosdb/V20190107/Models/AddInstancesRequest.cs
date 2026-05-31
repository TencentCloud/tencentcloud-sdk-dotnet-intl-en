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

    public class AddInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Cpu cores</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Memory in GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Number of added read-only instances. Value range: (0,16].
        /// </summary>
        [JsonProperty("ReadOnlyCount")]
        public long? ReadOnlyCount{ get; set; }

        /// <summary>
        /// <p>Instance Machine Type. Supported values are as follows:</p><ul><li>common: indicates universal type</li><li>exclusive: indicates exclusive</li></ul>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>Instance group ID, used when adding new instances to an existing RO group. If not passed, a new RO group will be created. The current version does not recommend transmitting this value.</p>
        /// </summary>
        [JsonProperty("InstanceGrpId")]
        [System.Obsolete]
        public string InstanceGrpId{ get; set; }

        /// <summary>
        /// <p>ID of the associated VPC network.</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID. If VpcId is set up, SubnetId is required.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// The port used when adding an RO group. Value range: [0,65535).
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// Instance name. String length range: [0,64).
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Whether to automatically select a voucher. 1: Yes; 0: No. Default is 0.</p>
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// <p>Database type, value ranges from...to...: </p><li> MYSQL </li>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>Order source, string length range [0,64)</p>
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// <p>Transaction mode. 0: place order and pay; 1: place order</p>
        /// </summary>
        [JsonProperty("DealMode")]
        public long? DealMode{ get; set; }

        /// <summary>
        /// <p>Parameter template ID</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>Parameter list. InstanceParams is valid only when ParamTemplateId is passed in.</p>
        /// </summary>
        [JsonProperty("InstanceParams")]
        public ModifyParamItem[] InstanceParams{ get; set; }

        /// <summary>
        /// <p>Security group ID. You can specify security groups when creating a read-only instance.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>proxy sync upgrade</p>
        /// </summary>
        [JsonProperty("UpgradeProxy")]
        public UpgradeProxy UpgradeProxy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "ReadOnlyCount", this.ReadOnlyCount);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceGrpId", this.InstanceGrpId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamSimple(map, prefix + "DealMode", this.DealMode);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamArrayObj(map, prefix + "InstanceParams.", this.InstanceParams);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "UpgradeProxy.", this.UpgradeProxy);
        }
    }
}

