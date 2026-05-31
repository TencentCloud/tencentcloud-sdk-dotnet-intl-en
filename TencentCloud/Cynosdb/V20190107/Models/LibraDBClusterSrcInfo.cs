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

    public class LibraDBClusterSrcInfo : AbstractModel
    {
        
        /// <summary>
        /// Source endpoint type
        /// </summary>
        [JsonProperty("SrcInstanceType")]
        public string SrcInstanceType{ get; set; }

        /// <summary>
        /// Network type.
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// Source instance ID
        /// </summary>
        [JsonProperty("SrcInstanceId")]
        public string SrcInstanceId{ get; set; }

        /// <summary>
        /// Source cluster ID
        /// </summary>
        [JsonProperty("SrcClusterId")]
        public string SrcClusterId{ get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Source sql mode
        /// </summary>
        [JsonProperty("SqlMode")]
        public string SqlMode{ get; set; }

        /// <summary>
        /// Source application id
        /// </summary>
        [JsonProperty("SrcAppId")]
        public long? SrcAppId{ get; set; }

        /// <summary>
        /// source account
        /// </summary>
        [JsonProperty("SrcUin")]
        public string SrcUin{ get; set; }

        /// <summary>
        /// sub-account
        /// </summary>
        [JsonProperty("SrcSubAccountUin")]
        public string SrcSubAccountUin{ get; set; }

        /// <summary>
        /// Account
        /// </summary>
        [JsonProperty("AccountMode")]
        public string AccountMode{ get; set; }

        /// <summary>
        /// Source instance region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Operation of the source instance
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcInstanceType", this.SrcInstanceType);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "SrcInstanceId", this.SrcInstanceId);
            this.SetParamSimple(map, prefix + "SrcClusterId", this.SrcClusterId);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "SqlMode", this.SqlMode);
            this.SetParamSimple(map, prefix + "SrcAppId", this.SrcAppId);
            this.SetParamSimple(map, prefix + "SrcUin", this.SrcUin);
            this.SetParamSimple(map, prefix + "SrcSubAccountUin", this.SrcSubAccountUin);
            this.SetParamSimple(map, prefix + "AccountMode", this.AccountMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
        }
    }
}

