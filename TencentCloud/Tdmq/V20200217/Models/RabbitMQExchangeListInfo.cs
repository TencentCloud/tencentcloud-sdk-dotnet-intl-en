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

    public class RabbitMQExchangeListInfo : AbstractModel
    {
        
        /// <summary>
        /// Exchange name.
        /// </summary>
        [JsonProperty("ExchangeName")]
        public string ExchangeName{ get; set; }

        /// <summary>
        /// Remarks
        /// 
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Exchange type. Valid values: "fanout", "direct", "topic", "headers".
        /// </summary>
        [JsonProperty("ExchangeType")]
        public string ExchangeType{ get; set; }

        /// <summary>
        /// Specifies the Host name of the Virtual switch.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Exchange creator. "system": "created by the system"; "user": "created by a user".
        /// </summary>
        [JsonProperty("ExchangeCreator")]
        public string ExchangeCreator{ get; set; }

        /// <summary>
        /// Exchange creation time.
        /// </summary>
        [JsonProperty("CreateTimeStamp")]
        public string CreateTimeStamp{ get; set; }

        /// <summary>
        /// Exchange modification time.
        /// </summary>
        [JsonProperty("ModTimeStamp")]
        public string ModTimeStamp{ get; set; }

        /// <summary>
        /// Input message rate.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageRateIn")]
        public float? MessageRateIn{ get; set; }

        /// <summary>
        /// Indicates the output message rate.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageRateOut")]
        public float? MessageRateOut{ get; set; }

        /// <summary>
        /// Whether the exchange is a durable one. true: durable; false: non-durable.
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// Whether automatic deletion is set for the exchange. true: automatic deletion set; false: automatic deletion not set.
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// Whether the exchange is an internal one. true: internal exchange.
        /// </summary>
        [JsonProperty("Internal")]
        public bool? Internal{ get; set; }

        /// <summary>
        /// Instance ID of the exchange.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Effective policy name.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// Extended parameters of the key-value object type.
        /// </summary>
        [JsonProperty("Arguments")]
        public string Arguments{ get; set; }

        /// <summary>
        /// Number of unscheduled delayed messages.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessagesDelayed")]
        public ulong? MessagesDelayed{ get; set; }

        /// <summary>
        /// Creation time timestamp.
        /// </summary>
        [JsonProperty("CreateTs")]
        public ulong? CreateTs{ get; set; }

        /// <summary>
        /// Modification time timestamp.
        /// </summary>
        [JsonProperty("ModifyTs")]
        public ulong? ModifyTs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExchangeName", this.ExchangeName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ExchangeType", this.ExchangeType);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "ExchangeCreator", this.ExchangeCreator);
            this.SetParamSimple(map, prefix + "CreateTimeStamp", this.CreateTimeStamp);
            this.SetParamSimple(map, prefix + "ModTimeStamp", this.ModTimeStamp);
            this.SetParamSimple(map, prefix + "MessageRateIn", this.MessageRateIn);
            this.SetParamSimple(map, prefix + "MessageRateOut", this.MessageRateOut);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "Internal", this.Internal);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Arguments", this.Arguments);
            this.SetParamSimple(map, prefix + "MessagesDelayed", this.MessagesDelayed);
            this.SetParamSimple(map, prefix + "CreateTs", this.CreateTs);
            this.SetParamSimple(map, prefix + "ModifyTs", this.ModifyTs);
        }
    }
}

