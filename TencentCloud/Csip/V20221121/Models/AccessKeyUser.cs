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

    public class AccessKeyUser : AbstractModel
    {
        
        /// <summary>
        /// Account ID
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 0 Root account 1 Sub-account
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Access method
        /// 0 API
        /// 1 Console and API
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// Security advice. Enumerated values: 0: Normal. 1: Process now. 2: Hardening recommended.
        /// </summary>
        [JsonProperty("Advice")]
        public long? Advice{ get; set; }

        /// <summary>
        /// Alarm information list.
        /// </summary>
        [JsonProperty("AccessKeyAlarmList")]
        public AccessKeyAlarmInfo[] AccessKeyAlarmList{ get; set; }

        /// <summary>
        /// Risk information list.
        /// </summary>
        [JsonProperty("AccessKeyRiskList")]
        public AccessKeyAlarmInfo[] AccessKeyRiskList{ get; set; }

        /// <summary>
        /// APPID of the account
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// Main account nickname
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Sub-account nickname
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// Uin of the main account to which the account belongs
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Account's own uin. For a root account, it is the same as the root account uin.
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// Login IP
        /// </summary>
        [JsonProperty("LoginIP")]
        public string LoginIP{ get; set; }

        /// <summary>
        /// Login address.
        /// </summary>
        [JsonProperty("LoginLocation")]
        public string LoginLocation{ get; set; }

        /// <summary>
        /// Log-in time
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }

        /// <summary>
        /// ISP name
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }

        /// <summary>
        /// Whether operation protection is enabled
        /// 0: not enabled
        /// 1: On.
        /// </summary>
        [JsonProperty("ActionFlag")]
        public long? ActionFlag{ get; set; }

        /// <summary>
        /// Whether login protection is enabled
        /// 0: not enabled
        /// 1: On.
        /// </summary>
        [JsonProperty("LoginFlag")]
        public long? LoginFlag{ get; set; }

        /// <summary>
        /// 0 indicates detected, and 1 indicates in-progress detection.
        /// </summary>
        [JsonProperty("CheckStatus")]
        public long? CheckStatus{ get; set; }

        /// <summary>
        /// Cloud vendor type. 0: Tencent Cloud. 1: Amazon Web Services. 2: Microsoft Azure. 3: Google Cloud. 4: Alibaba Cloud. 5: Huawei Cloud
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "Advice", this.Advice);
            this.SetParamArrayObj(map, prefix + "AccessKeyAlarmList.", this.AccessKeyAlarmList);
            this.SetParamArrayObj(map, prefix + "AccessKeyRiskList.", this.AccessKeyRiskList);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubNickname", this.SubNickname);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "LoginIP", this.LoginIP);
            this.SetParamSimple(map, prefix + "LoginLocation", this.LoginLocation);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
            this.SetParamSimple(map, prefix + "ActionFlag", this.ActionFlag);
            this.SetParamSimple(map, prefix + "LoginFlag", this.LoginFlag);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

