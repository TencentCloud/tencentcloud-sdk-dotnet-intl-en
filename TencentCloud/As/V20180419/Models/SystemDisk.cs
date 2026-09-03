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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SystemDisk : AbstractModel
    {
        
        /// <summary>
        /// <p>System disk type. For restrictions on system disk types, see <a href="https://www.tencentcloud.com/document/product/362/2353?from_cn_redirect=1">Cloud Disk Types</a>. Value range:</p><li>LOCAL_BASIC: local hard disk</li><li>LOCAL_SSD: local SSD</li><li>CLOUD_BASIC: basic cloud disk</li><li>CLOUD_PREMIUM: high-performance cloud block storage</li><li>CLOUD_SSD: SSD cloud disk</li><li>CLOUD_BSSD: universal SSD cloud disk</li><li>CLOUD_HSSD: enhanced SSD cloud disk</li><li>CLOUD_TSSD: ultra-fast SSD CBS</li><li>Default value: CLOUD_PREMIUM.</li>
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// <p>System disk size (GB). Default value: 50</p>
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// <p>Whether to encrypt the system disk. TRUE means encrypted, FALSE means not encrypted. The specific disk type, region, and KMS rules are validated by CVM.</p>
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// <p>KMS Key ID used for system disk encryption. The key validity, permission, as well as adaptability to disk type and region are validated by CVM.</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

