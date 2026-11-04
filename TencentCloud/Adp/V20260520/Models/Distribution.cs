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

    public class Distribution : AbstractModel
    {
        
        /// <summary>
        /// <p>Count of calls for this reply method</p>
        /// </summary>
        [JsonProperty("CallCount")]
        public string CallCount{ get; set; }

        /// <summary>
        /// <p>Percentage of this reply method in the total number of calls (percentage, 0–100, rounded to two decimal places; all 0 when no data is available, and the sum of all items is 100 when there is data)</p>
        /// </summary>
        [JsonProperty("Percentage")]
        public float? Percentage{ get; set; }

        /// <summary>
        /// <p>Reply method name (internationalized according to the request language; falls back to the Enumeration Name of reply_method when i18n is missing)</p>
        /// </summary>
        [JsonProperty("ReplyName")]
        public string ReplyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "ReplyName", this.ReplyName);
        }
    }
}

