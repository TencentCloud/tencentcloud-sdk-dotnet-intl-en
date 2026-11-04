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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationRecordTimeUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>Total time consumed for a single dialogue, in milliseconds</p>
        /// </summary>
        [JsonProperty("Elapsed")]
        public string Elapsed{ get; set; }

        /// <summary>
        /// <p>Time to first token, in milliseconds</p>
        /// </summary>
        [JsonProperty("FirstTokenCost")]
        public string FirstTokenCost{ get; set; }

        /// <summary>
        /// <p>Total time consumed for model inference, in milliseconds</p>
        /// </summary>
        [JsonProperty("TotalCost")]
        public string TotalCost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Elapsed", this.Elapsed);
            this.SetParamSimple(map, prefix + "FirstTokenCost", this.FirstTokenCost);
            this.SetParamSimple(map, prefix + "TotalCost", this.TotalCost);
        }
    }
}

