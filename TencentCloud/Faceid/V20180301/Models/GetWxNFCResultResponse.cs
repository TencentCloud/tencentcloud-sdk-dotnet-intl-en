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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetWxNFCResultResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>NFC billing result code. Each successful NFC read is billed once (duplicate billing does not occur for repeated pull of the same NFC request). Permissible range of billing result codes:<br>  0: Read successful, billed<br>-1: Read fail, free of charge</p>
        /// </summary>
        [JsonProperty("ResultCode")]
        public string ResultCode{ get; set; }

        /// <summary>
        /// <p>Identity card number</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdNum")]
        public string IdNum{ get; set; }

        /// <summary>
        /// <p>name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Portrait photo in the document</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Picture")]
        public string Picture{ get; set; }

        /// <summary>
        /// <p>Front photo of the identity document (portrait side)</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdCardFrontImg")]
        public string IdCardFrontImg{ get; set; }

        /// <summary>
        /// <p>Photo of the back of an identity document (national emblem side)</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdCardBackImg")]
        public string IdCardBackImg{ get; set; }

        /// <summary>
        /// <p>Date of birth</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BirthDate")]
        public string BirthDate{ get; set; }

        /// <summary>
        /// <p>Validity start time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>Validity end time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Address</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// <p>Ethnicity</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nation")]
        public string Nation{ get; set; }

        /// <summary>
        /// <p>Gender</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Sex")]
        public string Sex{ get; set; }

        /// <summary>
        /// <p>Document type</p><p>Enumeration value:</p><ul><li>01: ID card</li><li>03: Chinese passport</li><li>06: Hong Kong and Macau travel permit</li><li>07: Taiwan travel permit</li><li>08: Foreign passport</li><li>13: Permanent residence permit for foreigners</li><li>14: Residence Permit for Hong Kong (China), Macao (China), and Taiwan (China) residents</li><li>15: Return Home Permit</li><li>16: Travel permit for Chinese mainland residents to Taiwan (China)</li><li>99: Other documents</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// <p>English name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnName")]
        public string EnName{ get; set; }

        /// <summary>
        /// <p>Issuing authority</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SigningOrganization")]
        public string SigningOrganization{ get; set; }

        /// <summary>
        /// <p>Residence Permit for residents of Hong Kong (China), Macao (China) and Taiwan (China), passport number</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OtherIdNum")]
        public string OtherIdNum{ get; set; }

        /// <summary>
        /// <p>Travel document nationality</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// <p>Characters 29 to 42 in the second line of the machine-readable zone of the travel document</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PersonalNumber")]
        public string PersonalNumber{ get; set; }

        /// <summary>
        /// <p>Verification result of the document</p><ul><li>JSON format as follows: {"result_issuer":"issuer certificate legitimacy verification result","result_paper":"Document security object legitimacy verification result","result_data":"data tampering prevention verification result","result_chip":"chip replication prevention verification result"}. - Value ranges from 0 to 3: 0: verified, 1: verification failed, 2: unverified, 3: partially passed. When all four verification results are 0, it means the document is genuine.</li></ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CheckMRTD")]
        public string CheckMRTD{ get; set; }

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
            this.SetParamSimple(map, prefix + "ResultCode", this.ResultCode);
            this.SetParamSimple(map, prefix + "IdNum", this.IdNum);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Picture", this.Picture);
            this.SetParamSimple(map, prefix + "IdCardFrontImg", this.IdCardFrontImg);
            this.SetParamSimple(map, prefix + "IdCardBackImg", this.IdCardBackImg);
            this.SetParamSimple(map, prefix + "BirthDate", this.BirthDate);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Nation", this.Nation);
            this.SetParamSimple(map, prefix + "Sex", this.Sex);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "EnName", this.EnName);
            this.SetParamSimple(map, prefix + "SigningOrganization", this.SigningOrganization);
            this.SetParamSimple(map, prefix + "OtherIdNum", this.OtherIdNum);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "PersonalNumber", this.PersonalNumber);
            this.SetParamSimple(map, prefix + "CheckMRTD", this.CheckMRTD);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

