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

    public class GetDeployInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// The CNS address of the contract.
        /// </summary>
        [JsonProperty("Hash")]
        public string Hash{ get; set; }

        /// <summary>
        /// The main group ID of the contract.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// The DID of the organization that deployed the contract.
        /// </summary>
        [JsonProperty("DeployDid")]
        public string DeployDid{ get; set; }

        /// <summary>
        /// The TDID SDK version.
        /// </summary>
        [JsonProperty("SdkVersion")]
        public string SdkVersion{ get; set; }

        /// <summary>
        /// The TDID contract version.
        /// </summary>
        [JsonProperty("ContractVersion")]
        public string ContractVersion{ get; set; }

        /// <summary>
        /// The blockchain node version.
        /// </summary>
        [JsonProperty("BlockVersion")]
        public string BlockVersion{ get; set; }

        /// <summary>
        /// The IP address of the blockchain node.
        /// </summary>
        [JsonProperty("BlockIp")]
        public string BlockIp{ get; set; }

        /// <summary>
        /// The address of the DID contract.
        /// </summary>
        [JsonProperty("DidAddress")]
        public string DidAddress{ get; set; }

        /// <summary>
        /// The address of the claim protocol type (CPT) contract.
        /// </summary>
        [JsonProperty("CptAddress")]
        public string CptAddress{ get; set; }

        /// <summary>
        /// The address of the authority.
        /// </summary>
        [JsonProperty("AuthorityAddress")]
        public string AuthorityAddress{ get; set; }

        /// <summary>
        /// The evidence contract address.
        /// </summary>
        [JsonProperty("EvidenceAddress")]
        public string EvidenceAddress{ get; set; }

        /// <summary>
        /// The contract address of the specific issuer.
        /// </summary>
        [JsonProperty("SpecificAddress")]
        public string SpecificAddress{ get; set; }

        /// <summary>
        /// The chain ID.
        /// </summary>
        [JsonProperty("ChainId")]
        public string ChainId{ get; set; }

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
            this.SetParamSimple(map, prefix + "Hash", this.Hash);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "DeployDid", this.DeployDid);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "ContractVersion", this.ContractVersion);
            this.SetParamSimple(map, prefix + "BlockVersion", this.BlockVersion);
            this.SetParamSimple(map, prefix + "BlockIp", this.BlockIp);
            this.SetParamSimple(map, prefix + "DidAddress", this.DidAddress);
            this.SetParamSimple(map, prefix + "CptAddress", this.CptAddress);
            this.SetParamSimple(map, prefix + "AuthorityAddress", this.AuthorityAddress);
            this.SetParamSimple(map, prefix + "EvidenceAddress", this.EvidenceAddress);
            this.SetParamSimple(map, prefix + "SpecificAddress", this.SpecificAddress);
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

