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
        /// Whether the user modified the card recognition result
        /// </summary>
        [JsonProperty("IsEdit")]
        public bool? IsEdit{ get; set; }

        /// <summary>
        /// The download URL of the video used for identity document verification, which is valid for 10 minutes. This parameter is returned only if video-based identity document verification is enabled.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CardVideo")]
        public FileInfo CardVideo{ get; set; }

        /// <summary>
        /// The download URL of the identity document image, which is valid for 10 minutes.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CardImage")]
        public FileInfo CardImage{ get; set; }

        /// <summary>
        /// The OCR result (in JSON) of the identity document image. If verification or OCR fails, this parameter is left empty. The URL is valid for 10 minutes.
        /// (1) Hong Kong (China) identity card
        /// When the value of `IdCardType` is `HK`:
        /// - CnName (string): Name in Chinese.
        /// - EnName (string): Name in English.
        /// - TelexCode (string): The code corresponding to the name in Chinese.
        /// - Sex (string): Gender. Valid values: `M` (male) and `F` (female).
        /// - Birthday (string): Date of birth.
        /// - Permanent (int): Whether it is a permanent residence identity card. Valid values: `0` (non-permanent), `1` (permanent), and `-1` (unknown).
        /// - IdNum (string): Identity card number.
        /// - Symbol (string): The ID symbol below the date of birth, such as "***AZ".
        /// - FirstIssueDate (string): Month and year of first registration.
        /// - CurrentIssueDate (string): The date of latest issuance.
        /// 
        /// (2) Malaysian identity card
        /// When the value of `IdCardType` is `ML`:
        /// - Sex (string): Gender. Valid values: `LELAKI` (male) and `PEREMPUAN` (female).
        /// - Birthday (string): Date of birth.
        /// - ID (string): Identity card number.
        /// - Name (string): Name.
        /// - Address (string): Address.
        /// - Type (string): Identity document type.
        /// 
        /// (3) Philippine identity document
        /// When the value of `IdCardType` is `PhilippinesVoteID`:
        /// - Birthday (string): Date of birth.
        /// - Address (string): Address.
        /// - LastName (string): Last name.
        /// - FirstName (string): First name.
        /// - VIN (string): Voter's identification number (VIN).
        /// - CivilStatus (string): Civil status.
        /// - Citizenship (string): Citizenship.
        /// - PrecinctNo (string): Precinct.
        /// 
        /// When the value of `IdCardType` is `PhilippinesDrivingLicense`:
        /// - Sex (string): Gender.
        /// - Birthday (string): Date of birth.
        /// - Name (string): Name.
        /// - Address (string): Address.
        /// - LastName (string): Last name.
        /// - FirstName (string): First name.
        /// - MiddleName (string): Middle name.
        /// - Nationality (string): Nationality.
        /// - LicenseNo (string): License number.
        /// - ExpiresDate (string): Expiration date.
        /// - AgencyCode (string): Agency code.
        /// 
        /// When the value of `IdCardType` is `PhilippinesTinID`:
        /// - LicenseNumber (string): Tax identification number (TIN).
        /// - FullName (string): Full name.
        /// - Address (string): Address.
        /// - Birthday (string): Date of birth.
        /// - IssueDate (string): Issue date.
        /// 
        /// When the value of `IdCardType` is `PhilippinesSSSID`:
        /// - LicenseNumber (string): Common reference number (CRN).
        /// - FullName (string): Full name.
        /// - Birthday (string): Date of birth.
        /// 
        /// When the value of `IdCardType` is `PhilippinesUMID`:
        /// - Surname (string): Surname.
        /// - MiddleName (string):Middle name.
        /// - GivenName (string): Given name.
        /// - Sex (string): Gender.
        /// - Birthday (string): Date of birth.
        /// - Address (string): Address.
        /// - CRN (string): Common reference number (CRN).
        /// 
        /// (4) Indonesian identity card
        /// When the value of `IdCardType` is `IndonesiaIDCard`:
        /// - NIK (string): Single Identity Number.
        /// - Nama (string): Full name.
        /// - TempatTglLahir (string): Place and date of birth.
        /// - JenisKelamin (string): Gender.
        /// - GolDarah (string): Blood type.
        /// - Alamat (string): Address.
        /// - RTRW (string): Street.
        /// - KelDesa (string): Village.
        /// - Kecamatan (string): Region.
        /// - Agama (string): Religion.
        /// - StatusPerkawinan (string): Marital status.
        /// - Perkerjaan (string): Occupation.
        /// - KewargaNegaraan (string): Nationality.
        /// - BerlakuHingga (string): Expiry date.
        /// - IssuedDate (string): Issue date.
        /// 
        /// (5) A passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions
        /// When the value of `IdCardType` is `MLIDPassport`:
        /// - FullName (string): Full name.
        /// - Surname (string): Surname.
        /// - GivenName (string): Given name.
        /// - Birthday (string): Date of birth.
        /// - Sex (string): Gender. Valid values: `F` (female) and `M` (male).
        /// - DateOfExpiration (string): Expiration date.
        /// - IssuingCountry (string): Issuing country.
        /// - NationalityCode (string): Country/region code.
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
        /// The recognition results of ID card
        /// </summary>
        [JsonProperty("CardInfo")]
        [System.Obsolete]
        public CardInfo CardInfo{ get; set; }

        /// <summary>
        /// License OCR result
        /// </summary>
        [JsonProperty("NormalCardInfo")]
        public NormalCardInfo NormalCardInfo{ get; set; }

        /// <summary>
        /// Card warning information
        /// -9101 Alarm for covered certificate,
        /// -9102 Alarm for photocopied certificate,
        /// -9103 Alarm for photographed certificate,
        /// -9107 Alarm for reflective certificate,
        /// -9108 Alarm for blurry image,
        /// -9109 This capability is not enabled.
        /// </summary>
        [JsonProperty("WarnCardInfos")]
        public long?[] WarnCardInfos{ get; set; }

        /// <summary>
        /// Details of the OCR modifications for this EKYC card, when the user manually modifies the card recognition results (IsEdit=true), EditDetails will return the modified fields. When IsEdit=false, EditDetails is empty.
        /// </summary>
        [JsonProperty("EditDetails")]
        public EditDetail[] EditDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamSimple(map, prefix + "IsEdit", this.IsEdit);
            this.SetParamObj(map, prefix + "CardVideo.", this.CardVideo);
            this.SetParamObj(map, prefix + "CardImage.", this.CardImage);
            this.SetParamObj(map, prefix + "CardInfoOcrJson.", this.CardInfoOcrJson);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamObj(map, prefix + "CardInfo.", this.CardInfo);
            this.SetParamObj(map, prefix + "NormalCardInfo.", this.NormalCardInfo);
            this.SetParamArraySimple(map, prefix + "WarnCardInfos.", this.WarnCardInfos);
            this.SetParamArrayObj(map, prefix + "EditDetails.", this.EditDetails);
        }
    }
}

