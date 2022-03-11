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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateModuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Module name, such as video live streaming module name. It cannot start with a space or exceed 60 characters.
        /// </summary>
        [JsonProperty("ModuleName")]
        public string ModuleName{ get; set; }

        /// <summary>
        /// Default bandwidth in Mbps. It cannot exceed the bandwidth range. For more information, see `DescribeConfig`.
        /// </summary>
        [JsonProperty("DefaultBandWidth")]
        public long? DefaultBandWidth{ get; set; }

        /// <summary>
        /// Default image ID, such as `img-qsdf3ff2`.
        /// </summary>
        [JsonProperty("DefaultImageId")]
        public string DefaultImageId{ get; set; }

        /// <summary>
        /// Model ID.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Default system disk size in GB. It is 50 GB by default and cannot exceed the system disk size range. For more information, see `DescribeConfig`.
        /// </summary>
        [JsonProperty("DefaultSystemDiskSize")]
        public long? DefaultSystemDiskSize{ get; set; }

        /// <summary>
        /// Default data disk size in GB. It cannot exceed the system disk size range. For more information, see `DescribeConfig`.
        /// </summary>
        [JsonProperty("DefaultDataDiskSize")]
        public long? DefaultDataDiskSize{ get; set; }

        /// <summary>
        /// Whether to disable IP direct access. Valid values:
        /// true: yes
        /// false: no
        /// </summary>
        [JsonProperty("CloseIpDirect")]
        public bool? CloseIpDirect{ get; set; }

        /// <summary>
        /// List of tags.
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// List of default module security groups
        /// </summary>
        [JsonProperty("SecurityGroups")]
        public string[] SecurityGroups{ get; set; }

        /// <summary>
        /// Default inbound bandwidth in Mbps. It cannot exceed the bandwidth range. For more information, see `DescribeConfig`.
        /// </summary>
        [JsonProperty("DefaultBandWidthIn")]
        public long? DefaultBandWidthIn{ get; set; }

        /// <summary>
        /// Whether to prohibit public IP assignment
        /// </summary>
        [JsonProperty("DisableWanIp")]
        public bool? DisableWanIp{ get; set; }

        /// <summary>
        /// System disk information.
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// Data disk information.
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleName", this.ModuleName);
            this.SetParamSimple(map, prefix + "DefaultBandWidth", this.DefaultBandWidth);
            this.SetParamSimple(map, prefix + "DefaultImageId", this.DefaultImageId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "DefaultSystemDiskSize", this.DefaultSystemDiskSize);
            this.SetParamSimple(map, prefix + "DefaultDataDiskSize", this.DefaultDataDiskSize);
            this.SetParamSimple(map, prefix + "CloseIpDirect", this.CloseIpDirect);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamArraySimple(map, prefix + "SecurityGroups.", this.SecurityGroups);
            this.SetParamSimple(map, prefix + "DefaultBandWidthIn", this.DefaultBandWidthIn);
            this.SetParamSimple(map, prefix + "DisableWanIp", this.DisableWanIp);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
        }
    }
}

