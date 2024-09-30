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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiQualityControlTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Media quality inspection template ID.
        /// You can directly use a preset template or customize a template in the console. The preset templates are as follows:
        /// - 10: Enable all quality inspection items.
        /// - 20: Only enable quality inspection items corresponding to format diagnosis.
        /// - 30: Only enable quality inspection items corresponding to no-reference scoring.
        /// - 40: Only enable quality inspection items corresponding to screen quality.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// The channel extension parameter, which is a serialized JSON string.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChannelExtPara")]
        public string ChannelExtPara{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "ChannelExtPara", this.ChannelExtPara);
        }
    }
}

