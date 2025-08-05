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

    public class CompareResult : AbstractModel
    {
        
        /// <summary>
        /// The final verification result code.
        /// 0: Success.
        /// 1001: Failed to call the liveness detection engine.
        /// 1004: Face detection failed.
        /// 2004: The uploaded face image is too large or too small.
        /// 2012: The face is not fully exposed.
        /// 2013: No face is detected.
        /// 2014: The resolution of the uploaded image is too low . Please upload a new one.
        /// 2015: Face comparison failed.
        /// 2016: The similarity did not reach the passing standard.
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// The description of the final verification result.
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public string ErrorMsg{ get; set; }

        /// <summary>
        /// The liveness algorithm package generated during this SDK-based liveness detection.
        /// </summary>
        [JsonProperty("LiveData")]
        public FileInfo LiveData{ get; set; }

        /// <summary>
        /// The download URL of the video used for verification, which contains specific color reflection effects, is valid for 10 minutes.
        /// </summary>
        [JsonProperty("LiveVideo")]
        public FileInfo LiveVideo{ get; set; }

        /// <summary>
        /// Records the specific action performed by the user, used for AI Face Shield analysis.
        /// </summary>
        [JsonProperty("ActionVideo")]
        public FileInfo ActionVideo{ get; set; }

        /// <summary>
        /// The liveness detection result code.
        /// 0: Success.
        /// 1001: Failed to call the liveness detection engine.
        /// 1004: Face detection failed.
        /// </summary>
        [JsonProperty("LiveErrorCode")]
        public string LiveErrorCode{ get; set; }

        /// <summary>
        /// The description of the liveness detection result.
        /// </summary>
        [JsonProperty("LiveErrorMsg")]
        public string LiveErrorMsg{ get; set; }

        /// <summary>
        /// The download URL of the face screenshot during verification, which is valid for 10 minutes.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BestFrame")]
        public FileInfo BestFrame{ get; set; }

        /// <summary>
        /// The download URL of the profile photo screenshot from the identity document, which is valid for 10 minutes.
        /// </summary>
        [JsonProperty("ProfileImage")]
        public FileInfo ProfileImage{ get; set; }

        /// <summary>
        /// The face comparison result code.
        /// 0: Success.
        /// 2004: The uploaded face image is too large or too small.
        /// 2012: The face is not fully exposed.
        /// 2013: No face is detected.
        /// 2014: The resolution of the uploaded image is too low . Please upload a new one.
        /// 2015: Face comparison failed.
        /// 2016: The similarity did not reach the passing standard.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompareErrorCode")]
        public string CompareErrorCode{ get; set; }

        /// <summary>
        /// The description of the face comparison result.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CompareErrorMsg")]
        public string CompareErrorMsg{ get; set; }

        /// <summary>
        /// The similarity score of face comparison.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Sim")]
        public float? Sim{ get; set; }

        /// <summary>
        /// This parameter is disused.
        /// </summary>
        [JsonProperty("IsNeedCharge")]
        public bool? IsNeedCharge{ get; set; }

        /// <summary>
        /// The identity document photo info edited by the user. Currently, this parameter is not applied.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CardInfoInputJson")]
        public FileInfo CardInfoInputJson{ get; set; }

        /// <summary>
        /// The request ID of this verification process.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMsg", this.ErrorMsg);
            this.SetParamObj(map, prefix + "LiveData.", this.LiveData);
            this.SetParamObj(map, prefix + "LiveVideo.", this.LiveVideo);
            this.SetParamObj(map, prefix + "ActionVideo.", this.ActionVideo);
            this.SetParamSimple(map, prefix + "LiveErrorCode", this.LiveErrorCode);
            this.SetParamSimple(map, prefix + "LiveErrorMsg", this.LiveErrorMsg);
            this.SetParamObj(map, prefix + "BestFrame.", this.BestFrame);
            this.SetParamObj(map, prefix + "ProfileImage.", this.ProfileImage);
            this.SetParamSimple(map, prefix + "CompareErrorCode", this.CompareErrorCode);
            this.SetParamSimple(map, prefix + "CompareErrorMsg", this.CompareErrorMsg);
            this.SetParamSimple(map, prefix + "Sim", this.Sim);
            this.SetParamSimple(map, prefix + "IsNeedCharge", this.IsNeedCharge);
            this.SetParamObj(map, prefix + "CardInfoInputJson.", this.CardInfoInputJson);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

