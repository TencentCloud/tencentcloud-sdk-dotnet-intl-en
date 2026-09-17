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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcVideoTaskUsage : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InputTokens")]
        public long? InputTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ThoughtTokens")]
        public long? ThoughtTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InputImageCount")]
        public long? InputImageCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InputSeconds")]
        public long? InputSeconds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputSeconds")]
        public long? OutputSeconds{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TotalSeconds")]
        public long? TotalSeconds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "ThoughtTokens", this.ThoughtTokens);
            this.SetParamSimple(map, prefix + "InputImageCount", this.InputImageCount);
            this.SetParamSimple(map, prefix + "InputSeconds", this.InputSeconds);
            this.SetParamSimple(map, prefix + "OutputSeconds", this.OutputSeconds);
            this.SetParamSimple(map, prefix + "TotalSeconds", this.TotalSeconds);
        }
    }
}

