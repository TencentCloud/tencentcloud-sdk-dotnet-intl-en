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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRabbitMQServerlessExchangeRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VHost parameter.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// exchange name.
        /// </summary>
        [JsonProperty("ExchangeName")]
        public string ExchangeName{ get; set; }

        /// <summary>
        /// Specifies the exchange type. valid values: "fanout", "direct", "topic", "headers".
        /// </summary>
        [JsonProperty("ExchangeType")]
        public string ExchangeType{ get; set; }

        /// <summary>
        /// Specifies the remark for exchange.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Specifies whether it is a persistent exchange. when the cluster restarts, all exchanges with this field set to "false" will be cleared.
        /// </summary>
        [JsonProperty("Durable")]
        public bool? Durable{ get; set; }

        /// <summary>
        /// Whether to auto-delete this exchange. if set to "true", the exchange will be automatically deleted when all routing relationships on the current exchange are unbound.
        /// </summary>
        [JsonProperty("AutoDelete")]
        public bool? AutoDelete{ get; set; }

        /// <summary>
        /// Specifies whether it is an internal exchange. if set to "true", messages cannot be directly delivered to this exchange. they need to be forwarded through another exchange in the routing settings.
        /// </summary>
        [JsonProperty("Internal")]
        public bool? Internal{ get; set; }

        /// <summary>
        /// Alternative exchange. if a message cannot be sent to the current exchange, it will be sent to this alternative exchange.
        /// </summary>
        [JsonProperty("AlternateExchange")]
        public string AlternateExchange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "ExchangeName", this.ExchangeName);
            this.SetParamSimple(map, prefix + "ExchangeType", this.ExchangeType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Durable", this.Durable);
            this.SetParamSimple(map, prefix + "AutoDelete", this.AutoDelete);
            this.SetParamSimple(map, prefix + "Internal", this.Internal);
            this.SetParamSimple(map, prefix + "AlternateExchange", this.AlternateExchange);
        }
    }
}

