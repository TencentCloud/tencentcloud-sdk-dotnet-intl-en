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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQVirtualHostInfo : AbstractModel
    {
        
        /// <summary>
        /// Cluster instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Vhost name
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Vhost description information.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Vhost tags.
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Modification time.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Vhost overview statistics information.
        /// </summary>
        [JsonProperty("VirtualHostStatistics")]
        public RabbitMQVirtualHostStatistics VirtualHostStatistics{ get; set; }

        /// <summary>
        /// Message trace enabling status. true: enabled; false: disabled.
        /// </summary>
        [JsonProperty("TraceFlag")]
        public bool? TraceFlag{ get; set; }

        /// <summary>
        /// Vhost status, which corresponds to status in the native product console. Valid values: running, partial, stopped, and unknown.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Message backlog count.
        /// </summary>
        [JsonProperty("MessageHeapCount")]
        public long? MessageHeapCount{ get; set; }

        /// <summary>
        /// Message input rate.
        /// </summary>
        [JsonProperty("MessageRateIn")]
        public float? MessageRateIn{ get; set; }

        /// <summary>
        /// Message output rate.
        /// </summary>
        [JsonProperty("MessageRateOut")]
        public float? MessageRateOut{ get; set; }

        /// <summary>
        /// Whether an image queue policy exists. true: Exists; false: Does not exist.
        /// </summary>
        [JsonProperty("MirrorQueuePolicyFlag")]
        public bool? MirrorQueuePolicyFlag{ get; set; }

        /// <summary>
        /// Creation timestamp.
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// Modification timestamp.
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamObj(map, prefix + "VirtualHostStatistics.", this.VirtualHostStatistics);
            this.SetParamSimple(map, prefix + "TraceFlag", this.TraceFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MessageHeapCount", this.MessageHeapCount);
            this.SetParamSimple(map, prefix + "MessageRateIn", this.MessageRateIn);
            this.SetParamSimple(map, prefix + "MessageRateOut", this.MessageRateOut);
            this.SetParamSimple(map, prefix + "MirrorQueuePolicyFlag", this.MirrorQueuePolicyFlag);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
        }
    }
}

