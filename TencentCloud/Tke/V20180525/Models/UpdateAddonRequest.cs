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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAddonRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Add-on name
        /// </summary>
        [JsonProperty("AddonName")]
        public string AddonName{ get; set; }

        /// <summary>
        /// addon version (default does not update if not passed. if AddonVersion is not passed, RawValues must be passed.).
        /// </summary>
        [JsonProperty("AddonVersion")]
        public string AddonVersion{ get; set; }

        /// <summary>
        /// Parameters of the addon, which is a base64-transcoded string in json format. (the addon parameters are obtained through DescribeAddonValues. when RawValues is not passed, AddonVersion must be provided.).
        /// </summary>
        [JsonProperty("RawValues")]
        public string RawValues{ get; set; }

        /// <summary>
        /// The update policy for the addon parameter supports two strategies: replace and merge. the default value is merge, which is compatible with old version apis. replace: use new RawValues to fully replace the original RawValues of the addon. merge: add or update the corresponding parameters in the original RawValues of the addon based on new RawValues.
        /// </summary>
        [JsonProperty("UpdateStrategy")]
        public string UpdateStrategy{ get; set; }

        /// <summary>
        /// Specifies whether to only perform an update check. when set to true, only the check is performed without updating the component.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AddonName", this.AddonName);
            this.SetParamSimple(map, prefix + "AddonVersion", this.AddonVersion);
            this.SetParamSimple(map, prefix + "RawValues", this.RawValues);
            this.SetParamSimple(map, prefix + "UpdateStrategy", this.UpdateStrategy);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
        }
    }
}

