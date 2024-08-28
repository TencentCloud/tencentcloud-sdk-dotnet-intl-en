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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScreenProtection : AbstractModel
    {
        
        /// <summary>
        /// Type value: virus scanning, brute force cracking, vulnerability scan, baseline check
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Virus scanning: 0: never scanned or asset not paid; 1: scanned and malicious files found; 2: scanned but isolation protection disabled; 3: scanned, protection enabled, and no risk found.
        /// Brute force cracking: 0: protection disabled (asset not paid); 1: automatic blocking enabled.
        /// Vulnerability scan: 0: never scanned or asset not paid; 1: vulnerability found; 2: no risk found.
        /// Baseline check: 0: never checked or asset not paid; 1: baseline risks found; 2: no risk found.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

