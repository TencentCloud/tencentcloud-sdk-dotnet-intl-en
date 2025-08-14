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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSLInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance billing mode. 0 indicates postpaid, i.e., pay-as-you-go.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Instance storage type. Fill in CLOUD_HSSD to represent high-performance cloud storage.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// The disk capacity of a single node of the instance, in GB. The disk capacity of a single node should be greater than or equal to 100 and less than or equal to 250 x the number of CPU cores. The capacity adjustment step is 100.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Instance node specification. You can fill in 4C16G, 8C32G, 16C64G, or 32C128G, which is case-insensitive.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Detailed configuration of the instance AZ. Currently, multiple availability zones are supported. The number of AZs must be 1 or 3, including the region names, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        /// </summary>
        [JsonProperty("ZoneSettings")]
        public ZoneSetting[] ZoneSettings{ get; set; }

        /// <summary>
        /// List of tags to be bound to the instance.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Prepaid parameter.
        /// </summary>
        [JsonProperty("PrePaySetting")]
        public PrePaySetting PrePaySetting{ get; set; }

        /// <summary>
        /// The unique random identifier with a time efficiency of 5 minutes, which needs to be specified by the caller to prevent the client from creating resources repeatedly. For example: a9a90aa6-****-****-****-fae360632808.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeploymentMode")]
        public string DeploymentMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamArrayObj(map, prefix + "ZoneSettings.", this.ZoneSettings);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "PrePaySetting.", this.PrePaySetting);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "DeploymentMode", this.DeploymentMode);
        }
    }
}

