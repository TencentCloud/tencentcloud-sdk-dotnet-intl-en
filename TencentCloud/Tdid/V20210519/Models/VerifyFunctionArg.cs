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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyFunctionArg : AbstractModel
    {
        
        /// <summary>
        /// The claim protocol type (CPT) ID.
        /// </summary>
        [JsonProperty("CptId")]
        public ulong? CptId{ get; set; }

        /// <summary>
        /// The issuer DID.
        /// </summary>
        [JsonProperty("Issuer")]
        public string Issuer{ get; set; }

        /// <summary>
        /// The expiration time.
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public long? ExpirationDate{ get; set; }

        /// <summary>
        /// The claim.
        /// </summary>
        [JsonProperty("ClaimJson")]
        public string ClaimJson{ get; set; }

        /// <summary>
        /// The time when the credential was issued.
        /// </summary>
        [JsonProperty("IssuanceDate")]
        public long? IssuanceDate{ get; set; }

        /// <summary>
        /// The context.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// The ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// The signature.
        /// </summary>
        [JsonProperty("Proof")]
        public Proof Proof{ get; set; }

        /// <summary>
        /// The type.
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CptId", this.CptId);
            this.SetParamSimple(map, prefix + "Issuer", this.Issuer);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "ClaimJson", this.ClaimJson);
            this.SetParamSimple(map, prefix + "IssuanceDate", this.IssuanceDate);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Proof.", this.Proof);
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
        }
    }
}

