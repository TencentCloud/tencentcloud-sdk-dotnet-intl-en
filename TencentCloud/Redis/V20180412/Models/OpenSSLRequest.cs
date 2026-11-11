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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenSSLRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID. Log in to the <a href="https://console.cloud.tencent.com/redis/instance/list">Redis console</a> and copy it from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>SSL address type.</p><p>Enumeration values:</p><ul><li>0: Unlimited.</li><li>1: Private IPv4 address.</li><li>2: Private IPv6 address.</li><li>3: Public network.</li><li>-1: Unspecified.</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("AddressType")]
        public long? AddressType{ get; set; }

        /// <summary>
        /// <p>Key type.</p><p>Enumeration values:</p><ul><li>0: Tencent Cloud provides</li><li>1: User-defined certificate</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("CertSource")]
        public long? CertSource{ get; set; }

        /// <summary>
        /// <p>Switch time. (This parameter is deprecated and no longer effective.)</p><p>Enumeration values:</p><ul><li>1: Operate within the maintenance window: SSL encryption will be enabled and executed within the set maintenance window. Use the DescribeMaintenanceWindow interface to query the set maintenance time period.</li><li>2: Immediate operation: The operation will be executed immediately with no waiting for the maintenance window. The system default setting is immediate operation.</li></ul>
        /// </summary>
        [JsonProperty("SwitchOption")]
        [System.Obsolete]
        public long? SwitchOption{ get; set; }

        /// <summary>
        /// <p>Certificate ID of the SSL certificate service. Required when CertSource=1</p>
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// <p>Min TLS version</p><p>Enumeration values:</p><ul><li>TLSv1.0: TLSv1.0</li><li>TLSv1.1: TLSv1.1</li><li>TLSv1.2: TLSv1.2</li></ul>
        /// </summary>
        [JsonProperty("SSLMinVersion")]
        public string SSLMinVersion{ get; set; }

        /// <summary>
        /// <p>Target encryption mode</p><p>Enumeration values:</p><ul><li>required: Enforced encryption</li><li>flexible: Compatible mode</li></ul><p>Default value: flexible</p>
        /// </summary>
        [JsonProperty("EncryptionMode")]
        public string EncryptionMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
            this.SetParamSimple(map, prefix + "SwitchOption", this.SwitchOption);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "SSLMinVersion", this.SSLMinVersion);
            this.SetParamSimple(map, prefix + "EncryptionMode", this.EncryptionMode);
        }
    }
}

