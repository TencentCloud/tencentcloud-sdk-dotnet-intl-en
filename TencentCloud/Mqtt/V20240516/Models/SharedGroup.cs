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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SharedGroup : AbstractModel
    {
        
        /// <summary>
        /// Tencent Cloud MQTT instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Shared subscription group name
        /// </summary>
        [JsonProperty("SharedName")]
        public string SharedName{ get; set; }

        /// <summary>
        /// Shared group load balancing strategy 1.RANDOM 2.HASH_PARTITION
        /// </summary>
        [JsonProperty("LbStrategy")]
        public long? LbStrategy{ get; set; }

        /// <summary>
        /// Takes effect under the HASH_PARTITION policy. It indicates the delay time when a Client disconnects or a new Client comes online to join the subscription group for consumption.
        /// Range: 0–600 seconds
        /// </summary>
        [JsonProperty("ExpiryInterval")]
        public long? ExpiryInterval{ get; set; }

        /// <summary>
        /// Remark, length not exceeding 128 characters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// createTime, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Last update time, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "SharedName", this.SharedName);
            this.SetParamSimple(map, prefix + "LbStrategy", this.LbStrategy);
            this.SetParamSimple(map, prefix + "ExpiryInterval", this.ExpiryInterval);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

