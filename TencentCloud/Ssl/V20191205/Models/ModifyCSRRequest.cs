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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCSRRequest : AbstractModel
    {
        
        /// <summary>
        /// The CSR ID.	
        /// </summary>
        [JsonProperty("CSRId")]
        public long? CSRId{ get; set; }

        /// <summary>
        /// Whether to generate the CSR content. Once the CSR content is generated, the CSR record cannot be modified.
        /// </summary>
        [JsonProperty("Generate")]
        public bool? Generate{ get; set; }

        /// <summary>
        /// The domain.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        [JsonProperty("Organization")]
        public string Organization{ get; set; }

        /// <summary>
        /// The department.
        /// </summary>
        [JsonProperty("Department")]
        public string Department{ get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// The province.
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// The city.
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// The country or region.
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// The encryption algorithm. RSA and ECC are supported.	
        /// </summary>
        [JsonProperty("EncryptAlgo")]
        public string EncryptAlgo{ get; set; }

        /// <summary>
        /// The key pair parameter. For RSA, only the 2048-bit and 4096-bit key pairs are supported. For ECC, only prime256v1 is supported.
        /// </summary>
        [JsonProperty("KeyParameter")]
        public string KeyParameter{ get; set; }

        /// <summary>
        /// The remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// The password of the private key.
        /// </summary>
        [JsonProperty("KeyPassword")]
        public string KeyPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CSRId", this.CSRId);
            this.SetParamSimple(map, prefix + "Generate", this.Generate);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Organization", this.Organization);
            this.SetParamSimple(map, prefix + "Department", this.Department);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "EncryptAlgo", this.EncryptAlgo);
            this.SetParamSimple(map, prefix + "KeyParameter", this.KeyParameter);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "KeyPassword", this.KeyPassword);
        }
    }
}

