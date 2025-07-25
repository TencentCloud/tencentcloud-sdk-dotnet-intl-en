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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBFeaturesResponse : AbstractModel
    {
        
        /// <summary>
        /// Whether database audit is supported
        /// </summary>
        [JsonProperty("IsSupportAudit")]
        public bool? IsSupportAudit{ get; set; }

        /// <summary>
        /// Whether enabling audit requires a kernel version upgrade
        /// </summary>
        [JsonProperty("AuditNeedUpgrade")]
        public bool? AuditNeedUpgrade{ get; set; }

        /// <summary>
        /// Whether database encryption is supported
        /// </summary>
        [JsonProperty("IsSupportEncryption")]
        public bool? IsSupportEncryption{ get; set; }

        /// <summary>
        /// Whether enabling encryption requires a kernel version upgrade
        /// </summary>
        [JsonProperty("EncryptionNeedUpgrade")]
        public bool? EncryptionNeedUpgrade{ get; set; }

        /// <summary>
        /// Whether the instance is a remote read-only instance
        /// </summary>
        [JsonProperty("IsRemoteRo")]
        public bool? IsRemoteRo{ get; set; }

        /// <summary>
        /// Region of the source instance
        /// </summary>
        [JsonProperty("MasterRegion")]
        public string MasterRegion{ get; set; }

        /// <summary>
        /// Whether minor version upgrade is supported
        /// </summary>
        [JsonProperty("IsSupportUpdateSubVersion")]
        public bool? IsSupportUpdateSubVersion{ get; set; }

        /// <summary>
        /// The current kernel version
        /// </summary>
        [JsonProperty("CurrentSubVersion")]
        public string CurrentSubVersion{ get; set; }

        /// <summary>
        /// Available kernel version for upgrade
        /// </summary>
        [JsonProperty("TargetSubVersion")]
        public string TargetSubVersion{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsSupportAudit", this.IsSupportAudit);
            this.SetParamSimple(map, prefix + "AuditNeedUpgrade", this.AuditNeedUpgrade);
            this.SetParamSimple(map, prefix + "IsSupportEncryption", this.IsSupportEncryption);
            this.SetParamSimple(map, prefix + "EncryptionNeedUpgrade", this.EncryptionNeedUpgrade);
            this.SetParamSimple(map, prefix + "IsRemoteRo", this.IsRemoteRo);
            this.SetParamSimple(map, prefix + "MasterRegion", this.MasterRegion);
            this.SetParamSimple(map, prefix + "IsSupportUpdateSubVersion", this.IsSupportUpdateSubVersion);
            this.SetParamSimple(map, prefix + "CurrentSubVersion", this.CurrentSubVersion);
            this.SetParamSimple(map, prefix + "TargetSubVersion", this.TargetSubVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

