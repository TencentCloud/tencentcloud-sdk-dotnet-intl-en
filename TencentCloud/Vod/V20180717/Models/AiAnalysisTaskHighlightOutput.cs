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

    public class AiAnalysisTaskHighlightOutput : AbstractModel
    {
        
        /// <summary>
        /// Intelligent video highlight list.
        /// <font color=red>Note</font>: This list can only display up to the first 100 elements. To obtain the complete result, get it from the file corresponding to HighlightSetFileUrl.
        /// </summary>
        [JsonProperty("HighlightSet")]
        public MediaAiAnalysisHighlightItem[] HighlightSet{ get; set; }

        /// <summary>
        /// URL of the video intelligent highlight list file. The content of the file is JSON, and the data structure is consistent with the HighlightSet fields. The file is not retained permanently and will be deleted after the HighlightSetFileUrlExpireTime time point is reached.
        /// </summary>
        [JsonProperty("HighlightSetFileUrl")]
        public string HighlightSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the video intelligent highlight list file URL in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("HighlightSetFileUrlExpireTime")]
        public string HighlightSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "HighlightSet.", this.HighlightSet);
            this.SetParamSimple(map, prefix + "HighlightSetFileUrl", this.HighlightSetFileUrl);
            this.SetParamSimple(map, prefix + "HighlightSetFileUrlExpireTime", this.HighlightSetFileUrlExpireTime);
        }
    }
}

