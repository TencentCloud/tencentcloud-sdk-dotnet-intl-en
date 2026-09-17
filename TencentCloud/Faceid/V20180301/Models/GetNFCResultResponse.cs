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

    public class GetNFCResultResponse : AbstractModel
    {
        
        /// <summary>
        /// Billing result code. Each successful NFC read is billed once. Permissible range: 
        /// 
        /// 0: Read successful, billed. 
        /// -1: Read failed, not billed.
        /// </summary>
        [JsonProperty("ChargeCode")]
        public string ChargeCode{ get; set; }

        /// <summary>
        /// Document type. Value range: 
        /// 
        /// 01: ID card. 
        /// 02: Chinese passport. 
        /// 03: Hong Kong, China and Macao, China travel permit. 
        /// 99: Other document. 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// Document verification result. The items for NFC verification are as follows:
        /// {"result_issuer ":"Issuer certificate legitimacy verification result ","result_paper":"Document security object legitimacy verification result ","result_data" :"Data tampering prevention verification result ","result_chip" :"Document chip replication prevention verification result"} 
        /// Value range: 0: verification passed 1: verification failed 2: unverified 3: partially passed 
        /// When all four verification results are 0, the document is genuine.
        /// </summary>
        [JsonProperty("CheckMRTD")]
        public string CheckMRTD{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in identity card number, passport number, or Hong Kong, China and Macao, China travel permit with the identity card number recognized by NFC. 
        /// 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("IdNumCompareResult")]
        public string IdNumCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in name and the name recognized by NFC.
        /// 0: Consistent
        /// -1: Not the same
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("NameCompareResult")]
        public string NameCompareResult{ get; set; }

        /// <summary>
        /// Similarity score between the passed-in face image and the portrait photo recognized by NFC.
        /// - Value range: [0.00, 100.00].
        /// - It is recommended to determine the same person when the similarity is equal to or greater than 70. Customers can also self-adjust the threshold based on specific scenarios (with a threshold of 70, the false pass rate is one in a thousand; with a threshold of 80, the false pass rate is one in ten thousand).
        /// </summary>
        [JsonProperty("PictureCompareSim")]
        public float? PictureCompareSim{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in face image and the portrait photo recognized by NFC. 
        /// 
        /// 0: Same person (similarity equal to or greater than 70 points) 
        /// 1: Not the same person (similarity less than 70 points) 
        /// 2: Comparison failed (the input image quality is too low) 
        /// 3: Comparison failed (the input image contains no human face, an incomplete face, or multiple faces) 
        /// 4: Comparison failed (input image too large or too small) 
        /// 5: Comparison failed (NFC cannot read the portrait photo) 
        /// 6: Comparison failed (no input image data) 
        /// 7: Comparison failed (other reason)
        /// </summary>
        [JsonProperty("PictureCompareResult")]
        public string PictureCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in date of birth and the date of birth recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("BirthDateCompareResult")]
        public string BirthDateCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in validity start time and the validity start time recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("BeginTimeCompareResult")]
        public string BeginTimeCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in validity end time and the validity end time recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("EndTimeCompareResult")]
        public string EndTimeCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in address and the address recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("AddressCompareResult")]
        public string AddressCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in ethnicity and the ethnicity recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("NationCompareResult")]
        public string NationCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in sex and the sex recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("SexCompareResult")]
        public string SexCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in English name and the English name recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("EnNameCompareResult")]
        public string EnNameCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in issuing authority and the issuing authority recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("SigningOrganizationCompareResult")]
        public string SigningOrganizationCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in nationality and the nationality recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("NationalityCompareResult")]
        public string NationalityCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in country code and the country code recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("CountryCodeCompareResult")]
        public string CountryCodeCompareResult{ get; set; }

        /// <summary>
        /// Comparison result of the passed-in machine-readable code and the machine-readable code recognized by NFC. 
        /// 0: Consistent 
        /// -1: Not the same 
        /// -2: NFC recognition failed, unable to compare
        /// </summary>
        [JsonProperty("MachineReadCodeCompareResult")]
        public string MachineReadCodeCompareResult{ get; set; }

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
            this.SetParamSimple(map, prefix + "ChargeCode", this.ChargeCode);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "CheckMRTD", this.CheckMRTD);
            this.SetParamSimple(map, prefix + "IdNumCompareResult", this.IdNumCompareResult);
            this.SetParamSimple(map, prefix + "NameCompareResult", this.NameCompareResult);
            this.SetParamSimple(map, prefix + "PictureCompareSim", this.PictureCompareSim);
            this.SetParamSimple(map, prefix + "PictureCompareResult", this.PictureCompareResult);
            this.SetParamSimple(map, prefix + "BirthDateCompareResult", this.BirthDateCompareResult);
            this.SetParamSimple(map, prefix + "BeginTimeCompareResult", this.BeginTimeCompareResult);
            this.SetParamSimple(map, prefix + "EndTimeCompareResult", this.EndTimeCompareResult);
            this.SetParamSimple(map, prefix + "AddressCompareResult", this.AddressCompareResult);
            this.SetParamSimple(map, prefix + "NationCompareResult", this.NationCompareResult);
            this.SetParamSimple(map, prefix + "SexCompareResult", this.SexCompareResult);
            this.SetParamSimple(map, prefix + "EnNameCompareResult", this.EnNameCompareResult);
            this.SetParamSimple(map, prefix + "SigningOrganizationCompareResult", this.SigningOrganizationCompareResult);
            this.SetParamSimple(map, prefix + "NationalityCompareResult", this.NationalityCompareResult);
            this.SetParamSimple(map, prefix + "CountryCodeCompareResult", this.CountryCodeCompareResult);
            this.SetParamSimple(map, prefix + "MachineReadCodeCompareResult", this.MachineReadCodeCompareResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

