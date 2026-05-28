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

    public class RecognizePhilippinesUMIDOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// The surname.
        /// </summary>
        [JsonProperty("Surname")]
        public TextDetectionResult Surname{ get; set; }

        /// <summary>
        /// The middle name.
        /// </summary>
        [JsonProperty("MiddleName")]
        public TextDetectionResult MiddleName{ get; set; }

        /// <summary>
        /// The given name.
        /// </summary>
        [JsonProperty("GivenName")]
        public TextDetectionResult GivenName{ get; set; }

        /// <summary>
        /// The address.
        /// </summary>
        [JsonProperty("Address")]
        public TextDetectionResult Address{ get; set; }

        /// <summary>
        /// The date of birth.
        /// </summary>
        [JsonProperty("Birthday")]
        public TextDetectionResult Birthday{ get; set; }

        /// <summary>
        /// The common reference number (CRN).
        /// </summary>
        [JsonProperty("CRN")]
        public TextDetectionResult CRN{ get; set; }

        /// <summary>
        /// The gender.
        /// </summary>
        [JsonProperty("Sex")]
        public TextDetectionResult Sex{ get; set; }

        /// <summary>
        /// The Base64-encoded identity photo.
        /// </summary>
        [JsonProperty("HeadPortrait")]
        public TextDetectionResult HeadPortrait{ get; set; }

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
            this.SetParamObj(map, prefix + "Surname.", this.Surname);
            this.SetParamObj(map, prefix + "MiddleName.", this.MiddleName);
            this.SetParamObj(map, prefix + "GivenName.", this.GivenName);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamObj(map, prefix + "Birthday.", this.Birthday);
            this.SetParamObj(map, prefix + "CRN.", this.CRN);
            this.SetParamObj(map, prefix + "Sex.", this.Sex);
            this.SetParamObj(map, prefix + "HeadPortrait.", this.HeadPortrait);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

