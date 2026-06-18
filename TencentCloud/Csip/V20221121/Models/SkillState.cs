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

    public class SkillState : AbstractModel
    {
        
        /// <summary>
        /// SKILL Installation Status
        /// Enumeration value:
        /// 0: Not installed
        /// Installing
        /// 2: Installed
        /// 3: Installation failure
        /// 4: Uninstalling
        /// 5: Uninstallation failed.
        /// </summary>
        [JsonProperty("SkillInstallStatus")]
        public long? SkillInstallStatus{ get; set; }

        /// <summary>
        /// SKILL installation/uninstallation operation time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("SkillInstallTime")]
        public string SkillInstallTime{ get; set; }

        /// <summary>
        /// SKILL installation/uninstallation result description information
        /// </summary>
        [JsonProperty("SkillInstallResult")]
        public string SkillInstallResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillInstallStatus", this.SkillInstallStatus);
            this.SetParamSimple(map, prefix + "SkillInstallTime", this.SkillInstallTime);
            this.SetParamSimple(map, prefix + "SkillInstallResult", this.SkillInstallResult);
        }
    }
}

