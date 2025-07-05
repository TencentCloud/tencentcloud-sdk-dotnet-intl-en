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

    public class RecognizePhilippinesVoteIDOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// The Base64-encoded identity photo.
        /// </summary>
        [JsonProperty("HeadPortrait")]
        public TextDetectionResult HeadPortrait{ get; set; }

        /// <summary>
        /// The voter's identification number (VIN).
        /// </summary>
        [JsonProperty("VIN")]
        public TextDetectionResult VIN{ get; set; }

        /// <summary>
        /// The first name.
        /// </summary>
        [JsonProperty("FirstName")]
        public TextDetectionResult FirstName{ get; set; }

        /// <summary>
        /// The last name.
        /// </summary>
        [JsonProperty("LastName")]
        public TextDetectionResult LastName{ get; set; }

        /// <summary>
        /// The date of birth.
        /// </summary>
        [JsonProperty("Birthday")]
        public TextDetectionResult Birthday{ get; set; }

        /// <summary>
        /// The civil status.
        /// </summary>
        [JsonProperty("CivilStatus")]
        public TextDetectionResult CivilStatus{ get; set; }

        /// <summary>
        /// The citizenship.
        /// </summary>
        [JsonProperty("Citizenship")]
        public TextDetectionResult Citizenship{ get; set; }

        /// <summary>
        /// The address.
        /// </summary>
        [JsonProperty("Address")]
        public TextDetectionResult Address{ get; set; }

        /// <summary>
        /// The precinct.
        /// </summary>
        [JsonProperty("PrecinctNo")]
        public TextDetectionResult PrecinctNo{ get; set; }

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
            this.SetParamObj(map, prefix + "HeadPortrait.", this.HeadPortrait);
            this.SetParamObj(map, prefix + "VIN.", this.VIN);
            this.SetParamObj(map, prefix + "FirstName.", this.FirstName);
            this.SetParamObj(map, prefix + "LastName.", this.LastName);
            this.SetParamObj(map, prefix + "Birthday.", this.Birthday);
            this.SetParamObj(map, prefix + "CivilStatus.", this.CivilStatus);
            this.SetParamObj(map, prefix + "Citizenship.", this.Citizenship);
            this.SetParamObj(map, prefix + "Address.", this.Address);
            this.SetParamObj(map, prefix + "PrecinctNo.", this.PrecinctNo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

