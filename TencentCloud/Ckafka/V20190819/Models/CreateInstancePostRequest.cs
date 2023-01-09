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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancePostRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance name, which is a string of up to 64 characters. It can contain letters, digits, and hyphens (-) and must start with a letter.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance bandwidth
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// VPC ID. If this parameter is left empty, the classic network will be used by default.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID, which is required for a VPC but not for the classic network.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// The maximum retention period for instance logs in minutes. Default value: 1,440 minutes (1 day). Max value: 12960 minutes (90 days). This parameter is optional.
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// AZ
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// Cluster ID, which can be selected when you create an instance.
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
        }
    }
}

