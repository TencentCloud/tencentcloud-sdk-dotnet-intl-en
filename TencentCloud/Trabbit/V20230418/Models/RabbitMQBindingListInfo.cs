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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQBindingListInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Routing relationship id</p>
        /// </summary>
        [JsonProperty("BindingId")]
        public long? BindingId{ get; set; }

        /// <summary>
        /// <p>Vhost parameter</p>
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// <p>Source exchange name</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>Target type, queue or exchange</p>
        /// </summary>
        [JsonProperty("DestinationType")]
        public string DestinationType{ get; set; }

        /// <summary>
        /// <p>Target resource name</p>
        /// </summary>
        [JsonProperty("Destination")]
        public string Destination{ get; set; }

        /// <summary>
        /// <p>Bind key</p>
        /// </summary>
        [JsonProperty("RoutingKey")]
        public string RoutingKey{ get; set; }

        /// <summary>
        /// <p>Source exchange type</p>
        /// </summary>
        [JsonProperty("SourceExchangeType")]
        public string SourceExchangeType{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Modification time.</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>Bind parameter. Parameters can be passed in during binding for header type Exchange. No need to input for other types of Exchange.</p>
        /// </summary>
        [JsonProperty("Arguments")]
        public RabbitMQServerlessKeyValuePair[] Arguments{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BindingId", this.BindingId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "DestinationType", this.DestinationType);
            this.SetParamSimple(map, prefix + "Destination", this.Destination);
            this.SetParamSimple(map, prefix + "RoutingKey", this.RoutingKey);
            this.SetParamSimple(map, prefix + "SourceExchangeType", this.SourceExchangeType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArrayObj(map, prefix + "Arguments.", this.Arguments);
        }
    }
}

