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

    public class MPSSubtitleOutlineConfig : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubtitleOutlineConfigSwitch")]
        public long? SubtitleOutlineConfigSwitch{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineWidth")]
        public float? OutlineWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineWidthUnit")]
        public long? OutlineWidthUnit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineColor")]
        public string OutlineColor{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutlineAlpha")]
        public float? OutlineAlpha{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleOutlineConfigSwitch", this.SubtitleOutlineConfigSwitch);
            this.SetParamSimple(map, prefix + "OutlineWidth", this.OutlineWidth);
            this.SetParamSimple(map, prefix + "OutlineWidthUnit", this.OutlineWidthUnit);
            this.SetParamSimple(map, prefix + "OutlineColor", this.OutlineColor);
            this.SetParamSimple(map, prefix + "OutlineAlpha", this.OutlineAlpha);
        }
    }
}

