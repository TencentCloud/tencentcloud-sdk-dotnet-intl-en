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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateComplianceTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// List of asset types to be scanned
        /// `ASSET_CONTAINER`: Container.
        /// `ASSET_IMAGE`: Image.
        /// `ASSET_HOST`: Server.
        /// `ASSET_K8S`: K8s asset.
        /// A valid value must be entered for the `AssetTypeSet`, `PolicySetId`, or `PeriodTaskId` parameter.
        /// </summary>
        [JsonProperty("AssetTypeSet")]
        public string[] AssetTypeSet{ get; set; }

        /// <summary>
        /// Policy set ID
        /// </summary>
        [JsonProperty("PolicySetId")]
        public ulong? PolicySetId{ get; set; }

        /// <summary>
        /// Scheduled task ID
        /// </summary>
        [JsonProperty("PeriodTaskId")]
        public ulong? PeriodTaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AssetTypeSet.", this.AssetTypeSet);
            this.SetParamSimple(map, prefix + "PolicySetId", this.PolicySetId);
            this.SetParamSimple(map, prefix + "PeriodTaskId", this.PeriodTaskId);
        }
    }
}

