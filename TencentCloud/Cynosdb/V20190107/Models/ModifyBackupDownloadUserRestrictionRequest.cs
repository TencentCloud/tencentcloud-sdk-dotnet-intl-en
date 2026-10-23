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

    public class ModifyBackupDownloadUserRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// Download limit type. NoLimit: unlimited. LimitOnlyIntranet: restricted to private network. Customize: custom.
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }

        /// <summary>
        /// This parameter only supports In, which means the vpc specified by LimitVpc can be downloaded. The default is In.
        /// </summary>
        [JsonProperty("VpcComparisonSymbol")]
        public string VpcComparisonSymbol{ get; set; }

        /// <summary>
        /// In: download allowed for the specified ip; NotIn: download not allowed for the specified ip
        /// </summary>
        [JsonProperty("IpComparisonSymbol")]
        public string IpComparisonSymbol{ get; set; }

        /// <summary>
        /// vpc settings for download restriction
        /// </summary>
        [JsonProperty("LimitVpcs")]
        public BackupLimitVpcItem[] LimitVpcs{ get; set; }

        /// <summary>
        /// ip settings for download restrictions
        /// </summary>
        [JsonProperty("LimitIps")]
        public string[] LimitIps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
            this.SetParamSimple(map, prefix + "VpcComparisonSymbol", this.VpcComparisonSymbol);
            this.SetParamSimple(map, prefix + "IpComparisonSymbol", this.IpComparisonSymbol);
            this.SetParamArrayObj(map, prefix + "LimitVpcs.", this.LimitVpcs);
            this.SetParamArraySimple(map, prefix + "LimitIps.", this.LimitIps);
        }
    }
}

