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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeadLetterConfig : AbstractModel
    {
        
        /// <summary>
        /// Three modes are supported: DLQ, drop, and ignore error, which correspond to `DLQ`, `DROP`, and `IGNORE_ERROR` respectively
        /// </summary>
        [JsonProperty("DisposeMethod")]
        public string DisposeMethod{ get; set; }

        /// <summary>
        /// If the DLQ mode is set, this option is required. Error messages will be delivered to the corresponding Kafka topic
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CkafkaDeliveryParams")]
        public CkafkaDeliveryParams CkafkaDeliveryParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisposeMethod", this.DisposeMethod);
            this.SetParamObj(map, prefix + "CkafkaDeliveryParams.", this.CkafkaDeliveryParams);
        }
    }
}

