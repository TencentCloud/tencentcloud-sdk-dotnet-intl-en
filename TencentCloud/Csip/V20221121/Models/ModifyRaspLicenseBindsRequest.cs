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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRaspLicenseBindsRequest : AbstractModel
    {
        
        /// <summary>
        /// Asset type
        /// - CWP host security assets
        /// - TCSS_HOST container host node
        /// - TCSS_EKS container super node
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// Billing item type
        /// -sv_yunjing_vas_small small package
        /// -sv_yunjing_vas_medium medium package
        /// -sv_yunjing_vas_large package
        /// -sv_yunjing_vas_expansion expansion package
        /// </summary>
        [JsonProperty("InquireKey")]
        public string InquireKey{ get; set; }

        /// <summary>
        /// Instance ID array.
        /// </summary>
        [JsonProperty("QUUID")]
        public string[] QUUID{ get; set; }

        /// <summary>
        /// Whether to include all host instances.
        /// </summary>
        [JsonProperty("IsALL")]
        public bool? IsALL{ get; set; }

        /// <summary>
        /// Filter parameter. This parameter takes effect when IsALL is set to true, indicating that the filtered results apply to QUUIDs.
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "InquireKey", this.InquireKey);
            this.SetParamArraySimple(map, prefix + "QUUID.", this.QUUID);
            this.SetParamSimple(map, prefix + "IsALL", this.IsALL);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

