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

    public class HostAutoScaleConfig : AbstractModel
    {
        
        /// <summary>
        /// Host auto-scaling switch
        /// Enumeration values:
        /// ON: enable
        /// OFF: disabled.
        /// Supplemental description: If not passed, no modification is made. Map the underlying auto-purchase switch auto_repurchase_switch.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Scale-out version
        /// Enumeration values:
        /// PRO: Professional Edition
        /// ULTIMATE: Flagship edition
        /// Supplementary description: No modification will be made if this parameter is not passed in.
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
        }
    }
}

