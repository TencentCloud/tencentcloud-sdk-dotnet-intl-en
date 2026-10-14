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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaUsageItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of input images</p><p>Unit: count</p>
        /// </summary>
        [JsonProperty("InputImageCount")]
        public long? InputImageCount{ get; set; }

        /// <summary>
        /// <p>Input seconds</p><p>Unit: seconds</p>
        /// </summary>
        [JsonProperty("InputSeconds")]
        public long? InputSeconds{ get; set; }

        /// <summary>
        /// <p>Output seconds</p><p>Measurement unit: seconds</p>
        /// </summary>
        [JsonProperty("OutputSeconds")]
        public long? OutputSeconds{ get; set; }

        /// <summary>
        /// <p>Total number of seconds</p><p>Unit: seconds</p>
        /// </summary>
        [JsonProperty("TotalSeconds")]
        public long? TotalSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputImageCount", this.InputImageCount);
            this.SetParamSimple(map, prefix + "InputSeconds", this.InputSeconds);
            this.SetParamSimple(map, prefix + "OutputSeconds", this.OutputSeconds);
            this.SetParamSimple(map, prefix + "TotalSeconds", this.TotalSeconds);
        }
    }
}

