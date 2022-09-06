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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CardVerifyResult : AbstractModel
    {
        
        /// <summary>
        /// Whether the authentication or OCR process is successful.
        /// </summary>
        [JsonProperty("IsPass")]
        public bool? IsPass{ get; set; }

        /// <summary>
        /// The video for ID card authentication. This field is returned only if the video-based ID card authentication is enabled. The URL is valid for 10 minutes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CardVideo")]
        public FileInfo CardVideo{ get; set; }

        /// <summary>
        /// The identity document image. The URL is valid for 10 minutes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CardImage")]
        public FileInfo CardImage{ get; set; }

        /// <summary>
        /// The OCR result (in JSON) of the identity document image. If authentication or OCR fails, this parameter is left empty. The URL is valid for 10 minutes.
        /// When the value of `IdCardType` is `HK`:
        /// - CnName string: Chinese name
        /// - EnName string: English name
        /// - TelexCode string: The code corresponding to the Chinese name
        /// - Sex string: Gender. Valid values: `M` (male) and `F` (female).
        /// - Birthday string: Date of birth.
        /// - Permanent int: Whether it is a permanent residence identity card. Valid values: `0` (non-permanent), `1` (permanent), and `-1` (unknown).
        /// - IdNum string: ID number.
        /// - Symbol string: The ID symbol below the date of birth, such as "***AZ".
        /// - FirstIssueDate string: The date of first issuance.
        /// - CurrentIssueDate string: The date of latest issuance.
        /// 
        /// When the value of `IdCardType` is `ML`:
        /// - Sex string: `LELAKI` (male) and `PEREMPUAN` (female).
        /// - Birthday string: Date of birth.
        /// - ID string: ID number.
        /// - Name string: Name.
        /// - Address string: Address.
        /// - Type string: Identity document type.
        /// 
        /// When the value of `IdCardType` is `PhilippinesVoteID`:
        /// - Birthday string: Date of birth.
        /// - Address string: Address.
        /// - LastName string: Family name.
        /// - FirstName string: First name.
        /// - VIN string: VIN number.
        /// - CivilStatus string: Marital status.
        /// - Citizenship string: Citizenship.
        /// - PrecinctNo string: Region.
        /// 
        /// When the value of `IdCardType` is `PhilippinesDrivingLicense`:
        /// - Sex string: Gender.
        /// - Birthday string: Date of birth.
        /// - Name string: Name.
        /// - Address string: Address.
        /// - LastName string: Family name.
        /// - FirstName string: First name.
        /// - MiddleName string: Middle name.
        /// - Nationality string: Nationality.
        /// - LicenseNo string: License number.
        /// - ExpiresDate string: Validity period.
        /// - AgencyCode string: Agency code.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CardInfoOcrJson")]
        public FileInfo CardInfoOcrJson{ get; set; }

        /// <summary>
        /// The request ID of a single process.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamObj(map, prefix + "CardVideo.", this.CardVideo);
            this.SetParamObj(map, prefix + "CardImage.", this.CardImage);
            this.SetParamObj(map, prefix + "CardInfoOcrJson.", this.CardInfoOcrJson);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

