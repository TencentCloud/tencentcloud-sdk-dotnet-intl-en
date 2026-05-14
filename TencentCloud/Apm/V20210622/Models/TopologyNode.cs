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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopologyNode : AbstractModel
    {
        
        /// <summary>
        /// Error rate
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErrRate")]
        public float? ErrRate{ get; set; }

        /// <summary>
        /// Node type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Node name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Node weight
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Weight")]
        public float? Weight{ get; set; }

        /// <summary>
        /// Node color
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// response time
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// throughput
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Qps")]
        public float? Qps{ get; set; }

        /// <summary>
        /// Node type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Node size
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Size")]
        public string Size{ get; set; }

        /// <summary>
        /// Indicate whether the node is a component
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsModule")]
        public bool? IsModule{ get; set; }

        /// <summary>
        /// Node location information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Position")]
        public Position Position{ get; set; }

        /// <summary>
        /// Node tags
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public ApmTag[] Tags{ get; set; }

        /// <summary>
        /// Whether the node supports drill-down.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CanDrillDown")]
        public bool? CanDrillDown{ get; set; }

        /// <summary>
        /// Resource layer information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// Name of the topology node view.
        /// </summary>
        [JsonProperty("NodeView")]
        public string NodeView{ get; set; }

        /// <summary>
        /// Message consumption time of the MQ consumer, in ms.
        /// </summary>
        [JsonProperty("ConsumerDuration")]
        public float? ConsumerDuration{ get; set; }

        /// <summary>
        /// Error rate of the MQ consumers, in %.
        /// </summary>
        [JsonProperty("ConsumerErrRate")]
        public float? ConsumerErrRate{ get; set; }

        /// <summary>
        /// Throughput of the message queue (MQ) consumer.
        /// </summary>
        [JsonProperty("ConsumerQps")]
        public float? ConsumerQps{ get; set; }

        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrRate", this.ErrRate);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "IsModule", this.IsModule);
            this.SetParamObj(map, prefix + "Position.", this.Position);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CanDrillDown", this.CanDrillDown);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamSimple(map, prefix + "NodeView", this.NodeView);
            this.SetParamSimple(map, prefix + "ConsumerDuration", this.ConsumerDuration);
            this.SetParamSimple(map, prefix + "ConsumerErrRate", this.ConsumerErrRate);
            this.SetParamSimple(map, prefix + "ConsumerQps", this.ConsumerQps);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
        }
    }
}

