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

    public class HmtResidentPermitOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        [JsonProperty("Birth")]
        public string Birth{ get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// ID card number
        /// </summary>
        [JsonProperty("IdCardNo")]
        public string IdCardNo{ get; set; }

        /// <summary>
        /// 0: Front side.
        /// 1: Back side.
        /// </summary>
        [JsonProperty("CardType")]
        public long? CardType{ get; set; }

        /// <summary>
        /// Validity period
        /// </summary>
        [JsonProperty("ValidDate")]
        public string ValidDate{ get; set; }

        /// <summary>
        /// Issuing authority
        /// </summary>
        [JsonProperty("Authority")]
        public string Authority{ get; set; }

        /// <summary>
        /// Number of issues
        /// </summary>
        [JsonProperty("VisaNum")]
        public string VisaNum{ get; set; }

        /// <summary>
        /// Permit number
        /// </summary>
        [JsonProperty("PassNo")]
        public string PassNo{ get; set; }

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
            this.SetParamSimple(map, prefix + "Birth", this.Birth);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "IdCardNo", this.IdCardNo);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "ValidDate", this.ValidDate);
            this.SetParamSimple(map, prefix + "Authority", this.Authority);
            this.SetParamSimple(map, prefix + "VisaNum", this.VisaNum);
            this.SetParamSimple(map, prefix + "PassNo", this.PassNo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

