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

    public class BrazilDriverLicenseInfo : AbstractModel
    {
        
        /// <summary>
        /// Name.
        /// </summary>
        [JsonProperty("NOME")]
        public string NOME{ get; set; }

        /// <summary>
        /// Specifies the driver's license type.
        /// </summary>
        [JsonProperty("CatHab")]
        public string CatHab{ get; set; }

        /// <summary>
        /// Driver’s license id.
        /// </summary>
        [JsonProperty("CNHNumber")]
        public string CNHNumber{ get; set; }

        /// <summary>
        /// Expiration date.
        /// </summary>
        [JsonProperty("VALIDADE")]
        public string VALIDADE{ get; set; }

        /// <summary>
        /// Indicates the qualification.
        /// </summary>
        [JsonProperty("QUALIFICATION")]
        public string QUALIFICATION{ get; set; }

        /// <summary>
        /// Identity card number.
        /// </summary>
        [JsonProperty("IDENTIDADE")]
        public string IDENTIDADE{ get; set; }

        /// <summary>
        /// Tax number of the person.
        /// </summary>
        [JsonProperty("CPF")]
        public string CPF{ get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [JsonProperty("NASCIMENTO")]
        public string NASCIMENTO{ get; set; }

        /// <summary>
        /// Membership status.
        /// </summary>
        [JsonProperty("MEMBERSHIP")]
        public string MEMBERSHIP{ get; set; }

        /// <summary>
        /// Registration number.
        /// </summary>
        [JsonProperty("REGISTRO")]
        public string REGISTRO{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("OBSERVATIONS")]
        public string OBSERVATIONS{ get; set; }

        /// <summary>
        /// Issue date.
        /// </summary>
        [JsonProperty("IssueDate")]
        public string IssueDate{ get; set; }

        /// <summary>
        /// Issuing location.
        /// </summary>
        [JsonProperty("LOCAL")]
        public string LOCAL{ get; set; }

        /// <summary>
        /// Record number.
        /// </summary>
        [JsonProperty("BackNumber")]
        public string BackNumber{ get; set; }

        /// <summary>
        /// Specifies the avatar in base64 format.
        /// </summary>
        [JsonProperty("PortraitImage")]
        public string PortraitImage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NOME", this.NOME);
            this.SetParamSimple(map, prefix + "CatHab", this.CatHab);
            this.SetParamSimple(map, prefix + "CNHNumber", this.CNHNumber);
            this.SetParamSimple(map, prefix + "VALIDADE", this.VALIDADE);
            this.SetParamSimple(map, prefix + "QUALIFICATION", this.QUALIFICATION);
            this.SetParamSimple(map, prefix + "IDENTIDADE", this.IDENTIDADE);
            this.SetParamSimple(map, prefix + "CPF", this.CPF);
            this.SetParamSimple(map, prefix + "NASCIMENTO", this.NASCIMENTO);
            this.SetParamSimple(map, prefix + "MEMBERSHIP", this.MEMBERSHIP);
            this.SetParamSimple(map, prefix + "REGISTRO", this.REGISTRO);
            this.SetParamSimple(map, prefix + "OBSERVATIONS", this.OBSERVATIONS);
            this.SetParamSimple(map, prefix + "IssueDate", this.IssueDate);
            this.SetParamSimple(map, prefix + "LOCAL", this.LOCAL);
            this.SetParamSimple(map, prefix + "BackNumber", this.BackNumber);
            this.SetParamSimple(map, prefix + "PortraitImage", this.PortraitImage);
        }
    }
}

