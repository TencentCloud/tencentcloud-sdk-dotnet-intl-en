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

    public class AddServerlessRoInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster Id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Minimum specification of the ro instance</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>Maximum specification of ro instance</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>ro instance name</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>VPC network ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Subnet ID. If VpcId is set up, SubnetId is required.</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>Port used when adding new RO groups, value range [0,65535)</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>Security group ID. You can specify security groups when creating a read-only instance.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>Whether to automatically pause</p><p>Enumeration value:</p><ul><li>yes: Yes</li><li>no: No</li></ul>
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// <p>Auto-pause time</p><p>Unit: s</p>
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// <p>Instance parameter</p>
        /// </summary>
        [JsonProperty("InstanceParams")]
        public ModifyParamItem[] InstanceParams{ get; set; }

        /// <summary>
        /// <p>Parameter template</p>
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public long? ParamTemplateId{ get; set; }

        /// <summary>
        /// <p>Number of newly-added read-only instances</p>
        /// </summary>
        [JsonProperty("RoCount")]
        public long? RoCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamArrayObj(map, prefix + "InstanceParams.", this.InstanceParams);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "RoCount", this.RoCount);
        }
    }
}

