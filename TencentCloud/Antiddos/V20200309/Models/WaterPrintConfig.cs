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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WaterPrintConfig : AbstractModel
    {
        
        /// <summary>
        /// Watermark offset. Value range: [0, 100).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Start status. Valid values:
        /// `0`: manual start
        /// `1`: instant start
        /// ]
        /// </summary>
        [JsonProperty("OpenStatus")]
        public long? OpenStatus{ get; set; }

        /// <summary>
        /// List of forwarding listeners configured
        /// </summary>
        [JsonProperty("Listeners")]
        public ForwardListener[] Listeners{ get; set; }

        /// <summary>
        /// A list of watermark keys is generated after a watermark is added successfully. Each watermark can have up to 2 keys. When there is only one valid key, it cannot be deleted.
        /// </summary>
        [JsonProperty("Keys")]
        public WaterPrintKey[] Keys{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Verify")]
        public string Verify{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OpenStatus", this.OpenStatus);
            this.SetParamArrayObj(map, prefix + "Listeners.", this.Listeners);
            this.SetParamArrayObj(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "Verify", this.Verify);
        }
    }
}

