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

    public class DescribeRabbitMQExchangesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, such as amqp-xxxxxxxx. valid InstanceId can be queried by logging in to the TDMQ RabbitMQ console (https://console.cloud.tencent.com/trabbitmq/cluster?rid=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// VirtualHost name, such as testvhost. effective VirtualHost names can be queried by logging in to the TDMQ RabbitMQ console (https://console.cloud.tencent.com/trabbitmq/cluster?rid=1), clicking Vhost in the left sidebar, and finding the Vhost name in the Vhost list.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Specifies the pagination offset. default is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Pagination limit. default is 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Search keyword, supports fuzzy matching.  
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }

        /// <summary>
        /// Filters the exchange type. each element in the array is a selected filter type. only direct, fanout, topic, and header are supported.
        /// </summary>
        [JsonProperty("ExchangeTypeFilters")]
        public string[] ExchangeTypeFilters{ get; set; }

        /// <summary>
        /// Filter exchange creation source, "system": "system created", "user": "user created".
        /// </summary>
        [JsonProperty("ExchangeCreatorFilters")]
        public string[] ExchangeCreatorFilters{ get; set; }

        /// <summary>
        /// Exchange name, used for exact matching.
        /// </summary>
        [JsonProperty("ExchangeName")]
        public string ExchangeName{ get; set; }

        /// <summary>
        /// Sorting field:
        /// MessageRateInOut - Total production and consumption rate.
        /// MessageRateIn - Production rate.
        /// MessageRateOut - Consumption rate: Specifies the message consumption rate.
        /// </summary>
        [JsonProperty("SortElement")]
        public string SortElement{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: ascend and descend.
        /// Specifies the ascending order.
        /// Desc - descending.
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
            this.SetParamArraySimple(map, prefix + "ExchangeTypeFilters.", this.ExchangeTypeFilters);
            this.SetParamArraySimple(map, prefix + "ExchangeCreatorFilters.", this.ExchangeCreatorFilters);
            this.SetParamSimple(map, prefix + "ExchangeName", this.ExchangeName);
            this.SetParamSimple(map, prefix + "SortElement", this.SortElement);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}

