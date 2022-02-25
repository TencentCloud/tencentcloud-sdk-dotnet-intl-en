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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Consumer : AbstractModel
    {
        
        /// <summary>
        /// The time when the consumer started connecting.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConnectedSince")]
        public string ConnectedSince{ get; set; }

        /// <summary>
        /// Consumer address.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerAddr")]
        public string ConsumerAddr{ get; set; }

        /// <summary>
        /// Consumer name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerName")]
        public string ConsumerName{ get; set; }

        /// <summary>
        /// Consumer version.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientVersion")]
        public string ClientVersion{ get; set; }

        /// <summary>
        /// Serial number of the topic partition connected to the consumer.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConnectedSince", this.ConnectedSince);
            this.SetParamSimple(map, prefix + "ConsumerAddr", this.ConsumerAddr);
            this.SetParamSimple(map, prefix + "ConsumerName", this.ConsumerName);
            this.SetParamSimple(map, prefix + "ClientVersion", this.ClientVersion);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
        }
    }
}

