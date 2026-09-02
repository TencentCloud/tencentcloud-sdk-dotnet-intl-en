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

    public class AccessKeyWhiteList : AbstractModel
    {
        
        /// <summary>
        /// Allowlist ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Allowlist policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// ak allowlist
        /// </summary>
        [JsonProperty("AKList")]
        public string[] AKList{ get; set; }

        /// <summary>
        /// ip allowlist
        /// </summary>
        [JsonProperty("IPList")]
        public string[] IPList{ get; set; }

        /// <summary>
        /// ip type list IP type. 0: within the account (no remark). 1: outside the account (no remark). 2: within the account (remarked). 3: outside the account (remarked). 4: LAN (no remark). 5: LAN (remarked)
        /// </summary>
        [JsonProperty("IPTypeList")]
        public long?[] IPTypeList{ get; set; }

        /// <summary>
        /// API allowlist
        /// </summary>
        [JsonProperty("ActionList")]
        public string[] ActionList{ get; set; }

        /// <summary>
        /// Add the call method to the allowlist
        /// 0: all calling methods
        /// 1 Console
        /// 2 API
        /// -1 Nonexistent
        /// </summary>
        [JsonProperty("CallType")]
        public long? CallType{ get; set; }

        /// <summary>
        /// Error code allowlist (other error codes to be supplemented)
        /// 0: successful.
        /// </summary>
        [JsonProperty("ErrorCodeList")]
        public long?[] ErrorCodeList{ get; set; }

        /// <summary>
        /// Policy content/description
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Input type of ak 
        /// 0: Select from existing
        /// 1: Manually enter
        /// 2: Temporary key
        /// 3: Persistent key
        /// 4: All keys
        /// -1: None
        /// </summary>
        [JsonProperty("AkImportType")]
        public long? AkImportType{ get; set; }

        /// <summary>
        /// Main account AppID
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// uin of the main account
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Main account Nickname
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Whether to process past alarms
        /// </summary>
        [JsonProperty("NeedDealPastAlarm")]
        public bool? NeedDealPastAlarm{ get; set; }

        /// <summary>
        /// Processing status
        /// 0: Processing completed
        /// 1 Currently processing
        /// </summary>
        [JsonProperty("DealStatus")]
        public long? DealStatus{ get; set; }

        /// <summary>
        /// Select an API
        /// 0: Custom input
        /// 1: Select product+api format interaction
        /// 2: All interfaces
        /// </summary>
        [JsonProperty("ActionType")]
        public long? ActionType{ get; set; }

        /// <summary>
        /// List of binding policy IDs. If this parameter is empty, the policy takes effect globally.
        /// </summary>
        [JsonProperty("AlarmPolicyID")]
        public long?[] AlarmPolicyID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "AKList.", this.AKList);
            this.SetParamArraySimple(map, prefix + "IPList.", this.IPList);
            this.SetParamArraySimple(map, prefix + "IPTypeList.", this.IPTypeList);
            this.SetParamArraySimple(map, prefix + "ActionList.", this.ActionList);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamArraySimple(map, prefix + "ErrorCodeList.", this.ErrorCodeList);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "AkImportType", this.AkImportType);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "NeedDealPastAlarm", this.NeedDealPastAlarm);
            this.SetParamSimple(map, prefix + "DealStatus", this.DealStatus);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamArraySimple(map, prefix + "AlarmPolicyID.", this.AlarmPolicyID);
        }
    }
}

