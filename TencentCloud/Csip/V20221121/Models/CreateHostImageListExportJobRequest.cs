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

    public class CreateHostImageListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>MD5 of the cluster CA certificate (32-bit hexadecimal, required)</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Common ListFilter structure (including Filters array + ListFindOption pagination)<br>Supported filter fields: Host / ImageId / ImageName / HasRunningContainer</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>List of fields to export (all fields are exported if this parameter is not passed)<br>Enumeration values:<br>ImageId: image ID<br>ImageName: image name<br>ImageVersion: mirror version<br>ContainerCount: number of associated containers<br>HostCount: number of associated hosts<br>CreateTime: creation time<br>NickName: account nickname (automatically excluded in single account mode)<br>ScanStatus: scan status<br>LastScanTime: latest scan completion time<br>VulCountCritical: number of critical vulnerabilities<br>VulCountHigh: number of high vulnerabilities<br>VulCountMedium: number of medium vulnerabilities<br>VulCountLow: number of low vulnerabilities<br>VirusCountCritical: number of critical trojans<br>VirusCountHigh: number of high trojans<br>VirusCountMedium: number of medium trojans<br>VirusCountLow: number of low trojans<br>SensitiveCountCritical: number of critical sensitive data items<br>SensitiveCountHigh: number of high sensitive data items<br>SensitiveCountMedium: number of medium sensitive data items<br>SensitiveCountLow: number of low sensitive data items</p>
        /// </summary>
        [JsonProperty("ExportFields")]
        public string[] ExportFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "ExportFields.", this.ExportFields);
        }
    }
}

