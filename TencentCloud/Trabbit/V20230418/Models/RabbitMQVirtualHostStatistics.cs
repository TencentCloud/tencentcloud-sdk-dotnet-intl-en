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

    public class RabbitMQVirtualHostStatistics : AbstractModel
    {
        
        /// <summary>
        /// Number of queues of the current vhost.
        /// </summary>
        [JsonProperty("CurrentQueues")]
        public long? CurrentQueues{ get; set; }

        /// <summary>
        /// Number of exchanges in the current vhost.
        /// </summary>
        [JsonProperty("CurrentExchanges")]
        public long? CurrentExchanges{ get; set; }

        /// <summary>
        /// Number of current connections of the vhost.
        /// </summary>
        [JsonProperty("CurrentConnections")]
        public long? CurrentConnections{ get; set; }

        /// <summary>
        /// Number of channels for the current vhost.
        /// </summary>
        [JsonProperty("CurrentChannels")]
        public long? CurrentChannels{ get; set; }

        /// <summary>
        /// Number of users of the current vhost.
        /// </summary>
        [JsonProperty("CurrentUsers")]
        public long? CurrentUsers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CurrentQueues", this.CurrentQueues);
            this.SetParamSimple(map, prefix + "CurrentExchanges", this.CurrentExchanges);
            this.SetParamSimple(map, prefix + "CurrentConnections", this.CurrentConnections);
            this.SetParamSimple(map, prefix + "CurrentChannels", this.CurrentChannels);
            this.SetParamSimple(map, prefix + "CurrentUsers", this.CurrentUsers);
        }
    }
}

