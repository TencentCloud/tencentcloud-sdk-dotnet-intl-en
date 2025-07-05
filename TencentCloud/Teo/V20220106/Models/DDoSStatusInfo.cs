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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSStatusInfo : AbstractModel
    {
        
        /// <summary>
        /// This field is not supported. Value: `off`.
        /// </summary>
        [JsonProperty("AiStatus")]
        public string AiStatus{ get; set; }

        /// <summary>
        /// User appid
        /// </summary>
        [JsonProperty("Appid")]
        public string Appid{ get; set; }

        /// <summary>
        /// Protection level. Values: `low`, `middle`, and `high`.
        /// </summary>
        [JsonProperty("PlyLevel")]
        public string PlyLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AiStatus", this.AiStatus);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "PlyLevel", this.PlyLevel);
        }
    }
}

