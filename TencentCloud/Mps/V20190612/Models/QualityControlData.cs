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

    public class QualityControlData : AbstractModel
    {
        
        /// <summary>
        /// Whether there is an audio track. `true` indicates that there isn't.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoAudio")]
        public bool? NoAudio{ get; set; }

        /// <summary>
        /// Whether there is a video track. `true` indicates that there isn't.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NoVideo")]
        public bool? NoVideo{ get; set; }

        /// <summary>
        /// No-reference quality score of the video (100 points in total).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityEvaluationScore")]
        public long? QualityEvaluationScore{ get; set; }

        /// <summary>
        /// No-reference quality score of the video (MOS).
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("QualityEvaluationMeanOpinionScore")]
        public float? QualityEvaluationMeanOpinionScore{ get; set; }

        /// <summary>
        /// Exception items detected in content quality inspection.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QualityControlResultSet")]
        public QualityControlResult[] QualityControlResultSet{ get; set; }

        /// <summary>
        /// Exception items detected in format diagnosis.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ContainerDiagnoseResultSet")]
        public ContainerDiagnoseResultItem[] ContainerDiagnoseResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoAudio", this.NoAudio);
            this.SetParamSimple(map, prefix + "NoVideo", this.NoVideo);
            this.SetParamSimple(map, prefix + "QualityEvaluationScore", this.QualityEvaluationScore);
            this.SetParamSimple(map, prefix + "QualityEvaluationMeanOpinionScore", this.QualityEvaluationMeanOpinionScore);
            this.SetParamArrayObj(map, prefix + "QualityControlResultSet.", this.QualityControlResultSet);
            this.SetParamArrayObj(map, prefix + "ContainerDiagnoseResultSet.", this.ContainerDiagnoseResultSet);
        }
    }
}

