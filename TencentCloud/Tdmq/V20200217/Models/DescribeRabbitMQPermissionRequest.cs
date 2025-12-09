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

    public class DescribeRabbitMQPermissionRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, such as amqp-xxxxxxxx. effective InstanceId can be queried by logging in to the TDMQ RabbitMQ console (https://console.cloud.tencent.com/trabbitmq/cluster?rid=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Username, such as admin. effective User names can be found by logging in to the TDMQ RabbitMQ console (https://console.cloud.tencent.com/trabbitmq/cluster?rid=1), clicking a cluster in the cluster list, entering cluster details, and locating the list of users under the User and permission management tab, thereby finding the username.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// VirtualHost name, such as testvhost. valid VirtualHost names can be queried by logging in to the TDMQ RabbitMQ console (https://console.cloud.tencent.com/trabbitmq/cluster?rid=1), clicking Vhost in the left sidebar, and finding the Vhost name in the Vhost list.
        /// </summary>
        [JsonProperty("VirtualHost")]
        public string VirtualHost{ get; set; }

        /// <summary>
        /// Specifies the page Offset. default is 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Page Limit. default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "VirtualHost", this.VirtualHost);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

