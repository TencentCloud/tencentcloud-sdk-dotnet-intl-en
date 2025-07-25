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

    public class ModifyBackupDownloadRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// Type of the network restrictions for downloading backup files. Valid values:
        /// 
        /// - `NoLimit`: Backup files can be downloaded over both public and private networks.
        /// - `LimitOnlyIntranet`: Backup files can be downloaded only at private network addresses auto-assigned by Tencent Cloud.
        /// - `Customize`: Backup files can be downloaded only in the customized VPC.
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }

        /// <summary>
        /// Only `In` can be passed in for this parameter, indicating that backup files can be downloaded in the custom `LimitVpc`.
        /// </summary>
        [JsonProperty("VpcComparisonSymbol")]
        public string VpcComparisonSymbol{ get; set; }

        /// <summary>
        /// Whether backups can be downloaded at the custom `LimitIp` address.
        /// 
        /// - `In`: Download is allowed for the custom IP.
        /// - `NotIn`: Download is not allowed for the custom IP.
        /// </summary>
        [JsonProperty("IpComparisonSymbol")]
        public string IpComparisonSymbol{ get; set; }

        /// <summary>
        /// VPC ID of the custom backup file download address, which is required if `LimitType` is `Customize`.
        /// </summary>
        [JsonProperty("LimitVpc")]
        public BackupLimitVpcItem[] LimitVpc{ get; set; }

        /// <summary>
        /// VPC IP of the custom backup file download address, which is required if `LimitType` is `Customize`.
        /// </summary>
        [JsonProperty("LimitIp")]
        public string[] LimitIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
            this.SetParamSimple(map, prefix + "VpcComparisonSymbol", this.VpcComparisonSymbol);
            this.SetParamSimple(map, prefix + "IpComparisonSymbol", this.IpComparisonSymbol);
            this.SetParamArrayObj(map, prefix + "LimitVpc.", this.LimitVpc);
            this.SetParamArraySimple(map, prefix + "LimitIp.", this.LimitIp);
        }
    }
}

