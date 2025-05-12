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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Ability : AbstractModel
    {
        
        /// <summary>
        /// Whether secondary AZ is supported
        /// </summary>
        [JsonProperty("IsSupportSlaveZone")]
        public string IsSupportSlaveZone{ get; set; }

        /// <summary>
        /// The causes for no support from an availability zone.
        /// </summary>
        [JsonProperty("NonsupportSlaveZoneReason")]
        public string NonsupportSlaveZoneReason{ get; set; }

        /// <summary>
        /// Whether read-only instance is supported
        /// </summary>
        [JsonProperty("IsSupportRo")]
        public string IsSupportRo{ get; set; }

        /// <summary>
        /// Reasons why RO instances are not supported.
        /// </summary>
        [JsonProperty("NonsupportRoReason")]
        public string NonsupportRoReason{ get; set; }

        /// <summary>
        /// Whether manual snapshot backup initiation is supported.
        /// </summary>
        [JsonProperty("IsSupportManualSnapshot")]
        public string IsSupportManualSnapshot{ get; set; }

        /// <summary>
        /// Whether transparent data encryption is supported.
        /// </summary>
        [JsonProperty("IsSupportTransparentDataEncryption")]
        public string IsSupportTransparentDataEncryption{ get; set; }

        /// <summary>
        /// Reasons for no support of transparent data encryption.
        /// </summary>
        [JsonProperty("NoSupportTransparentDataEncryptionReason")]
        public string NoSupportTransparentDataEncryptionReason{ get; set; }

        /// <summary>
        /// Whether manual initiation of logical backup is supported.
        /// </summary>
        [JsonProperty("IsSupportManualLogic")]
        public string IsSupportManualLogic{ get; set; }


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
        }
    }
}

