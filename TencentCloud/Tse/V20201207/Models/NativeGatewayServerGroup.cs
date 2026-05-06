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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NativeGatewayServerGroup : AbstractModel
    {
        
        /// <summary>
        /// Cloud-Native Gateway Group Unique id
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description information
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Node specification, number of nodes info
        /// </summary>
        [JsonProperty("NodeConfig")]
        public CloudNativeAPIGatewayNodeConfig NodeConfig{ get; set; }

        /// <summary>
        /// Gateway group status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Whether it is the default group.
        /// 0: No.
        /// 1: Yes.
        /// </summary>
        [JsonProperty("IsFirstGroup")]
        public long? IsFirstGroup{ get; set; }

        /// <summary>
        /// Associate policy information
        /// </summary>
        [JsonProperty("BindingStrategy")]
        public CloudNativeAPIGatewayStrategy BindingStrategy{ get; set; }

        /// <summary>
        /// Gateway instance ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Bandwidth
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Modification time.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string SubnetIds{ get; set; }

        /// <summary>
        /// Default weight of the group
        /// </summary>
        [JsonProperty("DefaultWeight")]
        public long? DefaultWeight{ get; set; }

        /// <summary>
        /// elastic node
        /// </summary>
        [JsonProperty("ElasticNumber")]
        public ulong? ElasticNumber{ get; set; }

        /// <summary>
        /// Whether TOA is supported
        /// </summary>
        [JsonProperty("SupportTOA")]
        public bool? SupportTOA{ get; set; }

        /// <summary>
        /// Whether IPV6 is supported
        /// </summary>
        [JsonProperty("SupportIPV6")]
        public bool? SupportIPV6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamObj(map, prefix + "NodeConfig.", this.NodeConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsFirstGroup", this.IsFirstGroup);
            this.SetParamObj(map, prefix + "BindingStrategy.", this.BindingStrategy);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "SubnetIds", this.SubnetIds);
            this.SetParamSimple(map, prefix + "DefaultWeight", this.DefaultWeight);
            this.SetParamSimple(map, prefix + "ElasticNumber", this.ElasticNumber);
            this.SetParamSimple(map, prefix + "SupportTOA", this.SupportTOA);
            this.SetParamSimple(map, prefix + "SupportIPV6", this.SupportIPV6);
        }
    }
}

