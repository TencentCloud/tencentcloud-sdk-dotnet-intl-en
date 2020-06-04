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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MLIDPassportOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Passport ID
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("DateOfBirth")]
        public string DateOfBirth{ get; set; }

        /// <summary>
        /// Gender (F: female, M: male)
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        [JsonProperty("DateOfExpiration")]
        public string DateOfExpiration{ get; set; }

        /// <summary>
        /// Issuing country
        /// </summary>
        [JsonProperty("IssuingCountry")]
        public string IssuingCountry{ get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Alarm code
        /// -9103 Alarm for spoofed card
        /// -9102 Alarm for photocopied card
        /// -9106 Alarm for covered card
        /// </summary>
        [JsonProperty("Warn")]
        public long?[] Warn{ get; set; }

        /// <summary>
        /// Identity photo
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Extended field:
        /// {
        ///     ID:{
        ///         Confidence:0.9999
        ///     },
        ///     Name:{
        ///         Confidence:0.9996
        ///     }
        /// }
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
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DateOfBirth", this.DateOfBirth);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "DateOfExpiration", this.DateOfExpiration);
            this.SetParamSimple(map, prefix + "IssuingCountry", this.IssuingCountry);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamArraySimple(map, prefix + "Warn.", this.Warn);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "AdvancedInfo", this.AdvancedInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
