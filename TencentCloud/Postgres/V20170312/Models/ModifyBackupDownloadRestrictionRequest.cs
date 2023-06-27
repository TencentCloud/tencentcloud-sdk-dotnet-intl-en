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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupDownloadRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// Type of the network restrictions for downloading a backup file. Valid values: `NONE` (backups can be downloaded over both private and public networks), `INTRANET` (backups can only be downloaded over the private network), `CUSTOMIZE` (backups can be downloaded over specified VPCs or at specified IPs).
        /// </summary>
        [JsonProperty("RestrictionType")]
        public string RestrictionType{ get; set; }

        /// <summary>
        /// Whether VPC is allowed. Valid values: `ALLOW` (allow), `DENY` (deny).
        /// </summary>
        [JsonProperty("VpcRestrictionEffect")]
        public string VpcRestrictionEffect{ get; set; }

        /// <summary>
        /// Whether it is allowed to download the VPC ID list of the backup files.
        /// </summary>
        [JsonProperty("VpcIdSet")]
        public string[] VpcIdSet{ get; set; }

        /// <summary>
        /// Whether IP is allowed. Valid values: `ALLOW` (allow), `DENY` (deny).
        /// </summary>
        [JsonProperty("IpRestrictionEffect")]
        public string IpRestrictionEffect{ get; set; }

        /// <summary>
        /// Whether it is allowed to download the IP list of the backup files.
        /// </summary>
        [JsonProperty("IpSet")]
        public string[] IpSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RestrictionType", this.RestrictionType);
            this.SetParamSimple(map, prefix + "VpcRestrictionEffect", this.VpcRestrictionEffect);
            this.SetParamArraySimple(map, prefix + "VpcIdSet.", this.VpcIdSet);
            this.SetParamSimple(map, prefix + "IpRestrictionEffect", this.IpRestrictionEffect);
            this.SetParamArraySimple(map, prefix + "IpSet.", this.IpSet);
        }
    }
}

