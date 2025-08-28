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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBInstanceSSLRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Operation type. enable - enable SSL; disable - disable SSL; renew - update the validity period of the certificate.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Operation settings. 0 - execute immediately; 1 - execute within the maintenance time. The default value is 0.
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public ulong? WaitSwitch{ get; set; }

        /// <summary>
        /// Whether it is protected through KMS encryption. 0 - no; 1 - yes. The default value is 0.
        /// </summary>
        [JsonProperty("IsKMS")]
        public long? IsKMS{ get; set; }

        /// <summary>
        /// This parameter is required when the value of IsKMS is 1.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// This parameter is required when the value of IsKMS is 1.
        /// </summary>
        [JsonProperty("KeyRegion")]
        public string KeyRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
            this.SetParamSimple(map, prefix + "IsKMS", this.IsKMS);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyRegion", this.KeyRegion);
        }
    }
}

