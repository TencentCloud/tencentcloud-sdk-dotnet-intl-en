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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Highlight : AbstractModel
    {
        
        /// <summary>
        /// Highlight starting position.
        /// </summary>
        [JsonProperty("StartPos")]
        public string StartPos{ get; set; }

        /// <summary>
        /// Highlight end position.
        /// </summary>
        [JsonProperty("EndPos")]
        public string EndPos{ get; set; }

        /// <summary>
        /// Highlight subtext.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartPos", this.StartPos);
            this.SetParamSimple(map, prefix + "EndPos", this.EndPos);
            this.SetParamSimple(map, prefix + "Text", this.Text);
        }
    }
}

