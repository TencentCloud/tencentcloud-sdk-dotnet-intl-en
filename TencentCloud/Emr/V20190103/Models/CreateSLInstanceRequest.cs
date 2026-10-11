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
        /// Instance billing mode. Valid values: 0 (postpaid, that is, pay-as-you-go) and 1 (prepaid, that is, yearly/monthly subscription).
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Instance storage type. Valid values: CLOUD_HSSD (Enhanced SSD) and CLOUD_BSSD (Balanced SSD).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Disk capacity of a single node of the instance (GB). The disk capacity of a single node should be greater than or equal to 100 and less than or equal to 250 x the number of CPU cores. The capacity adjustment step is 100.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Instance node specifications. Valid values: 4C16G, 8C32G, 16C64G, and 32C128G. The value is case-insensitive.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// Detailed configuration of the instance AZ, including the region name, VPC information, and number of nodes. Currently, multiple AZs are supported. The number of AZs must be 1 or 3, and the total number of nodes across all AZs must be greater than or equal to 3 and less than or equal to 50.
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
        /// Unique random identifier with a time-to-live of 5 minutes, which needs to be specified by the caller to prevent the client from repeatedly creating resources, for example, a9a90aa6-****-****-****-fae360632808.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// Deployment mode.
        /// </summary>
        [JsonProperty("DeploymentMode")]
        public string DeploymentMode{ get; set; }

        /// <summary>
        /// Service username, which is optional for services without the need to set usernames. The value can contain 8 to 16 characters, including uppercase letters, lowercase letters, and digits.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


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
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

