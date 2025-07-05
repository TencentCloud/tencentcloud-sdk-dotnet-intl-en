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

    public class SubUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OwnerAppID")]
        public string OwnerAppID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OwnerNickName")]
        public string OwnerNickName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OwnerMemberID")]
        public string OwnerMemberID{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ServiceCount")]
        public long? ServiceCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InterfaceCount")]
        public long? InterfaceCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LogCount")]
        public long? LogCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ConfigRiskCount")]
        public long? ConfigRiskCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ActionRiskCount")]
        public long? ActionRiskCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsAccessCloudAudit")]
        public bool? IsAccessCloudAudit{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsAccessCheck")]
        public bool? IsAccessCheck{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsAccessUeba")]
        public bool? IsAccessUeba{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "OwnerAppID", this.OwnerAppID);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OwnerNickName", this.OwnerNickName);
            this.SetParamSimple(map, prefix + "OwnerMemberID", this.OwnerMemberID);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "InterfaceCount", this.InterfaceCount);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "LogCount", this.LogCount);
            this.SetParamSimple(map, prefix + "ConfigRiskCount", this.ConfigRiskCount);
            this.SetParamSimple(map, prefix + "ActionRiskCount", this.ActionRiskCount);
            this.SetParamSimple(map, prefix + "IsAccessCloudAudit", this.IsAccessCloudAudit);
            this.SetParamSimple(map, prefix + "IsAccessCheck", this.IsAccessCheck);
            this.SetParamSimple(map, prefix + "IsAccessUeba", this.IsAccessUeba);
        }
    }
}

