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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateExportComplianceStatusListJobRequest : AbstractModel
    {
        
        /// <summary>
        /// Asset type of the information to be exported
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Export by check item or asset. Valid values: `true` (export by asset); `false` (export by check item).
        /// </summary>
        [JsonProperty("ExportByAsset")]
        public bool? ExportByAsset{ get; set; }

        /// <summary>
        /// Valid values: `true` (export all); `false` (export based on the `IdList`).
        /// </summary>
        [JsonProperty("ExportAll")]
        public bool? ExportAll{ get; set; }

        /// <summary>
        /// List of IDs of assets or check items to be exported, which is determined by the value of `ExportByAsset`.
        /// </summary>
        [JsonProperty("IdList")]
        public ulong?[] IdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ExportByAsset", this.ExportByAsset);
            this.SetParamSimple(map, prefix + "ExportAll", this.ExportAll);
            this.SetParamArraySimple(map, prefix + "IdList.", this.IdList);
        }
    }
}

