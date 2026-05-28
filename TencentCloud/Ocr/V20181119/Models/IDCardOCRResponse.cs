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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Name (profile photo side)
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Gender (profile photo side)
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Ethnicity (profile photo side)
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// Date of birth (profile photo side)
        /// </summary>
        [JsonProperty("Birth")]
        public string Birth{ get; set; }

        /// <summary>
        /// Address (profile photo side)
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// ID number (profile photo side)
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// Issuing authority (national emblem side)
        /// </summary>
        [JsonProperty("Authority")]
        public string Authority{ get; set; }

        /// <summary>
        /// Validity period (national emblem side)
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// Extended information, which will be returned only when requested. For the input parameters, please see example 3 and example 4.
        /// `IdCard`: Base64-encoded content of the cropped ID card photo, which will be returned if `Config.CropIdCard` is set to `true`.
        /// `Portrait`: Base64-encoded content of the ID photo on the card, which will be returned if `Config.CropPortrait` is set to `true`.
        /// 
        /// `Quality`: Image quality score, which will be returned if `Config.Quality` is set to `true`. Value range: 0–100. The lower the score, the blurrier the image. The recommended threshold is ≥ 50.
        /// `BorderCodeValue`: Warning threshold score for incomplete ID card borders, which will be returned if `Config.BorderCheckWarn` is set to `true`. Value range: 0–100. The lower the score, the lower the probability of border occlusion. The recommended threshold value is ≤ 50.
        /// 
        /// `WarnInfos`: Warning information. Warning codes and descriptions are as follows:
        /// -9100: The ID card validity period is invalid.
        /// -9101: The ID card borders are incomplete.
        /// -9102: The ID card image is photocopied.
        /// -9103: The ID card image is spoofed. 
        /// -9104: The ID card is a temporary one. 
        /// -9105: The ID card frame is occluded.
        /// -9106: The ID card image is photoshopped.
        /// -9107: The ID card image has glares.
        /// </summary>
        [JsonProperty("AdvancedInfo")]
        public string AdvancedInfo{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Nation", this.Nation);
            this.SetParamSimple(map, prefix + "Birth", this.Birth);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Authority", this.Authority);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

