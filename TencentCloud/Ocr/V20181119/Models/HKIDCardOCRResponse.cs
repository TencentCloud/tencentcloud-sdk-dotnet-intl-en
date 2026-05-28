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

    public class HKIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Name in Chinese
        /// </summary>
        [JsonProperty("CnName")]
        public string CnName{ get; set; }

        /// <summary>
        /// Name in English
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// Telecode for the name in Chinese
        /// </summary>
        [JsonProperty("TelexCode")]
        public string TelexCode{ get; set; }

        /// <summary>
        /// Gender. Valid values: Male, Female
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Permanent identity card.
        /// 0: non-permanent;
        /// 1: permanent;
        /// -1: unknown.
        /// </summary>
        [JsonProperty("Permanent")]
        public long? Permanent{ get; set; }

        /// <summary>
        /// Identity card number
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// Document symbol, i.e., the symbol under the date of birth, such as "***AZ"
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// First issue date
        /// </summary>
        [JsonProperty("FirstIssueDate")]
        public string FirstIssueDate{ get; set; }

        /// <summary>
        /// Last receipt date
        /// </summary>
        [JsonProperty("CurrentIssueDate")]
        public string CurrentIssueDate{ get; set; }

        /// <summary>
        /// Authenticity check.
        /// 0: unable to judge (because the image is blurred, incomplete, reflective, too dark, etc.);
        /// 1: forged;
        /// 2: authentic.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FakeDetectResult")]
        [System.Obsolete]
        public long? FakeDetectResult{ get; set; }

        /// <summary>
        /// Base64-encoded large primary portrait photo from the left side of the new-generation Hong Kong Identity Card.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeadImage")]
        public string HeadImage{ get; set; }

        /// <summary>
        /// Base64-encoded small secondary portrait photo from the right side of the new-generation Hong Kong Identity Card.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SmallHeadImage")]
        public string SmallHeadImage{ get; set; }

        /// <summary>
        /// This field is deprecated and will always return an empty array. Usage is not recommended.
        /// </summary>
        [JsonProperty("WarningCode")]
        [System.Obsolete]
        public long?[] WarningCode{ get; set; }

        /// <summary>
        /// Card Warning Information
        /// 
        /// -9101 Alarm for covered certificate,
        /// -9102 Alarm for photocopied certificate,
        /// -9103 Alarm for photographed certificate,
        /// -9104 Alarm for PS certificate,
        /// -9107 Alarm for reflective certificate,
        /// -9108 Alarm for blurry image,
        /// -9109 This capability is not enabled.
        /// </summary>
        [JsonProperty("WarnCardInfos")]
        public long?[] WarnCardInfos{ get; set; }

        /// <summary>
        /// Text information incorporated within the laser-perforated see-through window on the new-generation Hong Kong Identity Card.
        /// </summary>
        [JsonProperty("WindowEmbeddedText")]
        public string WindowEmbeddedText{ get; set; }

        /// <summary>
        /// Versions of the Hong Kong Identity Card: HKID-2018, HKID-2003.
        /// </summary>
        [JsonProperty("HKIDVersion")]
        public string HKIDVersion{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CnName", this.CnName);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "TelexCode", this.TelexCode);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "Permanent", this.Permanent);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "FirstIssueDate", this.FirstIssueDate);
            this.SetParamSimple(map, prefix + "CurrentIssueDate", this.CurrentIssueDate);
            this.SetParamSimple(map, prefix + "FakeDetectResult", this.FakeDetectResult);
            this.SetParamSimple(map, prefix + "HeadImage", this.HeadImage);
            this.SetParamSimple(map, prefix + "SmallHeadImage", this.SmallHeadImage);
            this.SetParamArraySimple(map, prefix + "WarningCode.", this.WarningCode);
            this.SetParamArraySimple(map, prefix + "WarnCardInfos.", this.WarnCardInfos);
            this.SetParamSimple(map, prefix + "WindowEmbeddedText", this.WindowEmbeddedText);
            this.SetParamSimple(map, prefix + "HKIDVersion", this.HKIDVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

