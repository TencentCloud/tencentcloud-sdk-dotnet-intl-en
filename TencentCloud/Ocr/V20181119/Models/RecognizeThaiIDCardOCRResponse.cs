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

    public class RecognizeThaiIDCardOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// ID card number
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// Name in Thai
        /// </summary>
        [JsonProperty("ThaiName")]
        public string ThaiName{ get; set; }

        /// <summary>
        /// Name in English
        /// </summary>
        [JsonProperty("EnFirstName")]
        public string EnFirstName{ get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birthday")]
        public string Birthday{ get; set; }

        /// <summary>
        /// Date of issue
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// Expiration date
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// Name in English
        /// </summary>
        [JsonProperty("EnLastName")]
        public string EnLastName{ get; set; }

        /// <summary>
        /// Identity photo
        /// </summary>
        [JsonProperty("PortraitImage")]
        public string PortraitImage{ get; set; }

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
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "ThaiName", this.ThaiName);
            this.SetParamSimple(map, prefix + "EnFirstName", this.EnFirstName);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Birthday", this.Birthday);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "EnLastName", this.EnLastName);
            this.SetParamSimple(map, prefix + "PortraitImage", this.PortraitImage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

