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

    public class AddOnSubtitle : AbstractModel
    {
        
        /// <summary>
        /// The mode. Valid values:
        /// <li>`subtitle-stream`: Add a subtitle track.</li>
        /// <li>`close-caption-708`: u200dEmbed EA-708 subtitles in SEI frames.</li>
        /// <li>`close-caption-608`: Embed CEA-608 subtitles in SEI frames.</li>
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The subtitle file.
        /// Note: u200dThis field may returnu200d·nullu200d, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Subtitle")]
        public MediaInputInfo Subtitle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Subtitle.", this.Subtitle);
        }
    }
}

