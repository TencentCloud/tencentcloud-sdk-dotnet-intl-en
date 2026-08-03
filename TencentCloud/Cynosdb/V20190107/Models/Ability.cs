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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Ability : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether support from availability zone is supported</p>
        /// </summary>
        [JsonProperty("IsSupportSlaveZone")]
        public string IsSupportSlaveZone{ get; set; }

        /// <summary>
        /// <p>The causes for no support from availability zone</p>
        /// </summary>
        [JsonProperty("NonsupportSlaveZoneReason")]
        public string NonsupportSlaveZoneReason{ get; set; }

        /// <summary>
        /// <p>Whether RO instance is supported</p>
        /// </summary>
        [JsonProperty("IsSupportRo")]
        public string IsSupportRo{ get; set; }

        /// <summary>
        /// <p>Reason for unsupported RO instance</p>
        /// </summary>
        [JsonProperty("NonsupportRoReason")]
        public string NonsupportRoReason{ get; set; }

        /// <summary>
        /// <p>Whether manual snapshot backup initiation is supported</p>
        /// </summary>
        [JsonProperty("IsSupportManualSnapshot")]
        public string IsSupportManualSnapshot{ get; set; }

        /// <summary>
        /// <p>Whether transparent data encryption is supported</p>
        /// </summary>
        [JsonProperty("IsSupportTransparentDataEncryption")]
        public string IsSupportTransparentDataEncryption{ get; set; }

        /// <summary>
        /// <p>The causes for unsupported transparent data encryption</p>
        /// </summary>
        [JsonProperty("NoSupportTransparentDataEncryptionReason")]
        public string NoSupportTransparentDataEncryptionReason{ get; set; }

        /// <summary>
        /// <p>Whether manual initiation of logical backup is supported</p>
        /// </summary>
        [JsonProperty("IsSupportManualLogic")]
        public string IsSupportManualLogic{ get; set; }

        /// <summary>
        /// <p>Whether global encryption can be enabled</p>
        /// </summary>
        [JsonProperty("IsSupportGlobalEncryption")]
        public string IsSupportGlobalEncryption{ get; set; }

        /// <summary>
        /// <p>The causes for unsupported global encryption</p>
        /// </summary>
        [JsonProperty("NoSupportGlobalEncryptionReason")]
        public string NoSupportGlobalEncryptionReason{ get; set; }

        /// <summary>
        /// <p>Status code for unsupported transparent encryption reason</p>
        /// </summary>
        [JsonProperty("NoSupportTransparentDataEncryptionReasonCode")]
        public string NoSupportTransparentDataEncryptionReasonCode{ get; set; }

        /// <summary>
        /// <p>Status code for unsupported global encryption reason</p>
        /// </summary>
        [JsonProperty("NoSupportGlobalEncryptionReasonCode")]
        public string NoSupportGlobalEncryptionReasonCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSupportSlaveZone", this.IsSupportSlaveZone);
            this.SetParamSimple(map, prefix + "NonsupportSlaveZoneReason", this.NonsupportSlaveZoneReason);
            this.SetParamSimple(map, prefix + "IsSupportRo", this.IsSupportRo);
            this.SetParamSimple(map, prefix + "NonsupportRoReason", this.NonsupportRoReason);
            this.SetParamSimple(map, prefix + "IsSupportManualSnapshot", this.IsSupportManualSnapshot);
            this.SetParamSimple(map, prefix + "IsSupportTransparentDataEncryption", this.IsSupportTransparentDataEncryption);
            this.SetParamSimple(map, prefix + "NoSupportTransparentDataEncryptionReason", this.NoSupportTransparentDataEncryptionReason);
            this.SetParamSimple(map, prefix + "IsSupportManualLogic", this.IsSupportManualLogic);
            this.SetParamSimple(map, prefix + "IsSupportGlobalEncryption", this.IsSupportGlobalEncryption);
            this.SetParamSimple(map, prefix + "NoSupportGlobalEncryptionReason", this.NoSupportGlobalEncryptionReason);
            this.SetParamSimple(map, prefix + "NoSupportTransparentDataEncryptionReasonCode", this.NoSupportTransparentDataEncryptionReasonCode);
            this.SetParamSimple(map, prefix + "NoSupportGlobalEncryptionReasonCode", this.NoSupportGlobalEncryptionReasonCode);
        }
    }
}

