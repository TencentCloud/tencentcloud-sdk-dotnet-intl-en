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

    public class GetDataPanelResponse : AbstractModel
    {
        
        /// <summary>
        /// The number of blockchain networks.
        /// </summary>
        [JsonProperty("BlockNetworkCount")]
        public long? BlockNetworkCount{ get; set; }

        /// <summary>
        /// The blockchain network name.
        /// </summary>
        [JsonProperty("BlockNetworkName")]
        public string BlockNetworkName{ get; set; }

        /// <summary>
        /// The current block height.
        /// </summary>
        [JsonProperty("BlockHeight")]
        public long? BlockHeight{ get; set; }

        /// <summary>
        /// The blockchain network type.
        /// </summary>
        [JsonProperty("BlockNetworkType")]
        public long? BlockNetworkType{ get; set; }

        /// <summary>
        /// The number of DIDs.
        /// </summary>
        [JsonProperty("DidCount")]
        public long? DidCount{ get; set; }

        /// <summary>
        /// The number of claim protocol types (CPT).
        /// </summary>
        [JsonProperty("CptCount")]
        public long? CptCount{ get; set; }

        /// <summary>
        /// The number of certified authorities.
        /// </summary>
        [JsonProperty("CertificatedAuthCount")]
        public long? CertificatedAuthCount{ get; set; }

        /// <summary>
        /// The number of credentials issued.
        /// </summary>
        [JsonProperty("IssueCptCount")]
        public long? IssueCptCount{ get; set; }

        /// <summary>
        /// The number of new DIDs in the current week.
        /// </summary>
        [JsonProperty("NewDidCount")]
        public long? NewDidCount{ get; set; }

        /// <summary>
        /// The number of BCOS networks.
        /// </summary>
        [JsonProperty("BcosCount")]
        public long? BcosCount{ get; set; }

        /// <summary>
        /// The number of Fabric networks.
        /// </summary>
        [JsonProperty("FabricCount")]
        public long? FabricCount{ get; set; }

        /// <summary>
        /// The number of ChainMaker networks.
        /// </summary>
        [JsonProperty("ChainMakerCount")]
        public long? ChainMakerCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "BlockNetworkCount", this.BlockNetworkCount);
            this.SetParamSimple(map, prefix + "BlockNetworkName", this.BlockNetworkName);
            this.SetParamSimple(map, prefix + "BlockHeight", this.BlockHeight);
            this.SetParamSimple(map, prefix + "BlockNetworkType", this.BlockNetworkType);
            this.SetParamSimple(map, prefix + "DidCount", this.DidCount);
            this.SetParamSimple(map, prefix + "CptCount", this.CptCount);
            this.SetParamSimple(map, prefix + "CertificatedAuthCount", this.CertificatedAuthCount);
            this.SetParamSimple(map, prefix + "IssueCptCount", this.IssueCptCount);
            this.SetParamSimple(map, prefix + "NewDidCount", this.NewDidCount);
            this.SetParamSimple(map, prefix + "BcosCount", this.BcosCount);
            this.SetParamSimple(map, prefix + "FabricCount", this.FabricCount);
            this.SetParamSimple(map, prefix + "ChainMakerCount", this.ChainMakerCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

