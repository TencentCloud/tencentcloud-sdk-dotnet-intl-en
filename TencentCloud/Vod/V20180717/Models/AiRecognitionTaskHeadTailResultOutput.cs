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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiRecognitionTaskHeadTailResultOutput : AbstractModel
    {
        
        /// <summary>
        /// Confidence of recognized opening credits. Value range: 0-100.
        /// </summary>
        [JsonProperty("HeadConfidence")]
        public float? HeadConfidence{ get; set; }

        /// <summary>
        /// End time point of video opening credits in seconds.
        /// </summary>
        [JsonProperty("HeadTimeOffset")]
        public float? HeadTimeOffset{ get; set; }

        /// <summary>
        /// Confidence of recognized closing credits. Value range: 0-100.
        /// </summary>
        [JsonProperty("TailConfidence")]
        public float? TailConfidence{ get; set; }

        /// <summary>
        /// Start time point of video closing credits in seconds.
        /// </summary>
        [JsonProperty("TailTimeOffset")]
        public float? TailTimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HeadConfidence", this.HeadConfidence);
            this.SetParamSimple(map, prefix + "HeadTimeOffset", this.HeadTimeOffset);
            this.SetParamSimple(map, prefix + "TailConfidence", this.TailConfidence);
            this.SetParamSimple(map, prefix + "TailTimeOffset", this.TailTimeOffset);
        }
    }
}

