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

    public class ModifySandboxAlertStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Alarm type
        /// Enumeration values:
        /// ACL: access control
        /// DLP: data leakage protection
        /// LLM_AUDIT: LLM audit
        /// </summary>
        [JsonProperty("AlertType")]
        public string AlertType{ get; set; }

        /// <summary>
        /// Asset type to which it belongs
        /// Enumeration values:
        /// HOST: Host
        /// CONTAINER: Container
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// Alarm record ID list
        /// Input parameter limits: non-empty, 1-100 in length, take effect after deduplication.
        /// </summary>
        [JsonProperty("IDList")]
        public long?[] IDList{ get; set; }

        /// <summary>
        /// Target Operation
        /// Enumeration values:
        /// HANDLED: processed
        /// IGNORE: ignored
        /// PASS: allowlisted
        /// DELETE: Delete (cannot be undone)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlertType", this.AlertType);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamArraySimple(map, prefix + "IDList.", this.IDList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

