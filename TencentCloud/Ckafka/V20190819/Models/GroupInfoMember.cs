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

    public class GroupInfoMember : AbstractModel
    {
        
        /// <summary>
        /// Unique ID generated for consumer in consumer group by coordinator
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// `client.id` information by the client consumer SDK
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Generally stores client IP address
        /// </summary>
        [JsonProperty("ClientHost")]
        public string ClientHost{ get; set; }

        /// <summary>
        /// Stores the information of partition assigned to this consumer
        /// </summary>
        [JsonProperty("Assignment")]
        public Assignment Assignment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "ClientHost", this.ClientHost);
            this.SetParamObj(map, prefix + "Assignment.", this.Assignment);
        }
    }
}

