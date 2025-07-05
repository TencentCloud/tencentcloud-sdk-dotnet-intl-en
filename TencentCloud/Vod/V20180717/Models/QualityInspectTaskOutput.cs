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

    public class QualityInspectTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// Whether the media files have no audio track, range: <li>0: No, that is, there is an audio track;</li> <li>1: Yes, that is, there is no audio track.</li>
        /// </summary>
        [JsonProperty("NoAudio")]
        public long? NoAudio{ get; set; }

        /// <summary>
        /// Whether the media files have no video track, range: <li>0: No, that is, there is a video track;</li> <li>1: Yes, that is, there is no video track.</li>
        /// </summary>
        [JsonProperty("NoVideo")]
        public long? NoVideo{ get; set; }

        /// <summary>
        /// Quality score, value range: [0, 100].
        /// </summary>
        [JsonProperty("QualityEvaluationScore")]
        public ulong? QualityEvaluationScore{ get; set; }

        /// <summary>
        /// Abnormal items list detected of media quality inspection task
        /// </summary>
        [JsonProperty("QualityInspectResultSet")]
        public QualityInspectResultItem[] QualityInspectResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoAudio", this.NoAudio);
            this.SetParamSimple(map, prefix + "NoVideo", this.NoVideo);
            this.SetParamSimple(map, prefix + "QualityEvaluationScore", this.QualityEvaluationScore);
            this.SetParamArrayObj(map, prefix + "QualityInspectResultSet.", this.QualityInspectResultSet);
        }
    }
}

