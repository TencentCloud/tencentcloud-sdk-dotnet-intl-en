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

    public class CloneViralContent : AbstractModel
    {
        
        /// <summary>
        /// <p>Custom prompt describing requirements for video generation</p>
        /// </summary>
        [JsonProperty("UserPrompt")]
        public string UserPrompt{ get; set; }

        /// <summary>
        /// <p>Target language for video generation. Default: not specified. Supported values: zh / en / ja / ko / es / pt / instrumental (pure music without voiceover)</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Target market. Default: not specified. Supported values: north_america / europe / china / japan / korea / sea / brazil</p>
        /// </summary>
        [JsonProperty("Market")]
        public string Market{ get; set; }

        /// <summary>
        /// <p>Fission level. Values: exact/low/medium/high. Default: exact (1:1 clone)</p>
        /// </summary>
        [JsonProperty("FissionLevel")]
        public string FissionLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserPrompt", this.UserPrompt);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Market", this.Market);
            this.SetParamSimple(map, prefix + "FissionLevel", this.FissionLevel);
        }
    }
}

