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

    public class MPSSelectingSubtitleAreasConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Automatically select a custom region. For the selected areas, the AI model is used to automatically detect and extract the target content.</p>
        /// </summary>
        [JsonProperty("AutoAreas")]
        public MPSEraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// <p>Width of the sample video or image, in pixels.</p>
        /// </summary>
        [JsonProperty("SampleWidth")]
        public ulong? SampleWidth{ get; set; }

        /// <summary>
        /// <p>Height of the sample video or image, in pixels.</p>
        /// </summary>
        [JsonProperty("SampleHeight")]
        public ulong? SampleHeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamSimple(map, prefix + "SampleWidth", this.SampleWidth);
            this.SetParamSimple(map, prefix + "SampleHeight", this.SampleHeight);
        }
    }
}

