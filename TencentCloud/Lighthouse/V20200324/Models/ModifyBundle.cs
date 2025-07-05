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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBundle : AbstractModel
    {
        
        /// <summary>
        /// Price difference that you need to pay for the new instance package after change.
        /// </summary>
        [JsonProperty("ModifyPrice")]
        public Price ModifyPrice{ get; set; }

        /// <summary>
        /// Package change status. Valid values:
        /// <li>SOLD_OUT: packages are sold out</li>
        /// <li>AVAILABLE: packages can be changed</li>
        /// <li>UNAVAILABLE: packages cannot be changed currently</li>
        /// </summary>
        [JsonProperty("ModifyBundleState")]
        public string ModifyBundleState{ get; set; }

        /// <summary>
        /// Package information.
        /// </summary>
        [JsonProperty("Bundle")]
        public Bundle Bundle{ get; set; }

        /// <summary>
        /// The reason of package changing failure. It’s empty if the package change status is `AVAILABLE`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NotSupportModifyMessage")]
        public string NotSupportModifyMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ModifyPrice.", this.ModifyPrice);
            this.SetParamSimple(map, prefix + "ModifyBundleState", this.ModifyBundleState);
            this.SetParamObj(map, prefix + "Bundle.", this.Bundle);
            this.SetParamSimple(map, prefix + "NotSupportModifyMessage", this.NotSupportModifyMessage);
        }
    }
}

