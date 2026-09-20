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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerificationDetail : AbstractModel
    {
        
        /// <summary>
        /// Final result of this verification. 0 indicates that the verification is passed and the person is determined to be the same person.
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// Final result description of this verification
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// Liveness detection result of this verification. 0 indicates success.
        /// </summary>
        [JsonProperty("LivenessErrorCode")]
        public long? LivenessErrorCode{ get; set; }

        /// <summary>
        /// Description of the liveness detection result for this verification
        /// </summary>
        [JsonProperty("LivenessErrorMsg")]
        public string LivenessErrorMsg{ get; set; }

        /// <summary>
        /// Result of this verification comparison. 0 indicates that the best face photo collected from the video stream and the uploaded image for comparison are determined to be the same person.
        /// </summary>
        [JsonProperty("CompareErrorCode")]
        public long? CompareErrorCode{ get; set; }

        /// <summary>
        /// Result description of this verification comparison
        /// </summary>
        [JsonProperty("CompareErrorMsg")]
        public string CompareErrorMsg{ get; set; }

        /// <summary>
        /// Verification timestamp (ms) this time
        /// </summary>
        [JsonProperty("ReqTimestamp")]
        public ulong? ReqTimestamp{ get; set; }

        /// <summary>
        /// Similarity between the best face photo collected from the video stream in this verification and the uploaded image for comparison. Value range: [0.00, 100.00]. By default, the two are determined to be the same person when the similarity is at least 70.
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// Unique identifier for this verification
        /// </summary>
        [JsonProperty("Seq")]
        public string Seq{ get; set; }

        /// <summary>
        /// Description of the detailed reason why the current request was rejected in the liveness phase. This parameter is returned only for the PLUS version of the eKYC service.
        /// -Details as follows:
        /// 01-User eyes closed throughout
        /// 02 - User has not completed the specified action
        /// 03-Suspected rephotography attack
        /// 04-Suspected synthesis attack
        /// 05-Suspected fraud template
        /// 06-Suspected watermark
        /// 07-Reflection validation failed
        /// 08-Suspected midway change person
        /// 09: Poor face quality
        /// 10-distance check failed
        /// 11-Suspected adversarial sample attack
        /// 12-Mouth area suspected of attack traces
        /// 13-Eye area suspected to have attack traces
        /// 14-Eye or mouth covered
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// Example value: ["01"].
        /// </summary>
        [JsonProperty("LivenessInfoTag")]
        public string[] LivenessInfoTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamSimple(map, prefix + "LivenessErrorCode", this.LivenessErrorCode);
            this.SetParamSimple(map, prefix + "LivenessErrorMsg", this.LivenessErrorMsg);
            this.SetParamSimple(map, prefix + "CompareErrorCode", this.CompareErrorCode);
            this.SetParamSimple(map, prefix + "CompareErrorMsg", this.CompareErrorMsg);
            this.SetParamSimple(map, prefix + "ReqTimestamp", this.ReqTimestamp);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamArraySimple(map, prefix + "LivenessInfoTag.", this.LivenessInfoTag);
        }
    }
}

