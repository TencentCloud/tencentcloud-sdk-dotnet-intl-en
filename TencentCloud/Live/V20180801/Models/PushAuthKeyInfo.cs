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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PushAuthKeyInfo : AbstractModel
    {
        
        /// <summary>
        /// Domain name.
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Whether to enable. 0: disabled; 1: enabled.
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// Master authentication key.
        /// </summary>
        [JsonProperty("MasterAuthKey")]
        public string MasterAuthKey{ get; set; }

        /// <summary>
        /// Standby authentication key.
        /// </summary>
        [JsonProperty("BackupAuthKey")]
        public string BackupAuthKey{ get; set; }

        /// <summary>
        /// Validity period in seconds.
        /// </summary>
        [JsonProperty("AuthDelta")]
        public ulong? AuthDelta{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "MasterAuthKey", this.MasterAuthKey);
            this.SetParamSimple(map, prefix + "BackupAuthKey", this.BackupAuthKey);
            this.SetParamSimple(map, prefix + "AuthDelta", this.AuthDelta);
        }
    }
}

