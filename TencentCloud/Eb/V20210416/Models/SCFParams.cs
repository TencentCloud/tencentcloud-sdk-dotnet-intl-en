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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SCFParams : AbstractModel
    {
        
        /// <summary>
        /// Maximum waiting time for batch delivery
        /// </summary>
        [JsonProperty("BatchTimeout")]
        public long? BatchTimeout{ get; set; }

        /// <summary>
        /// Maximum number of events in batch delivery
        /// </summary>
        [JsonProperty("BatchEventCount")]
        public long? BatchEventCount{ get; set; }

        /// <summary>
        /// Enables batch delivery
        /// </summary>
        [JsonProperty("EnableBatchDelivery")]
        public bool? EnableBatchDelivery{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BatchTimeout", this.BatchTimeout);
            this.SetParamSimple(map, prefix + "BatchEventCount", this.BatchEventCount);
            this.SetParamSimple(map, prefix + "EnableBatchDelivery", this.EnableBatchDelivery);
        }
    }
}

