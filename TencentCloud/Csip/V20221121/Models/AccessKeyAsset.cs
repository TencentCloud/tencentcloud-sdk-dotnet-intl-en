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

    public class AccessKeyAsset : AbstractModel
    {
        
        /// <summary>
        /// AK id.
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// AK name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Account associate APPID.
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// Account associate Uin belonging to main account.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// Nickname of the main account.
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// Sub-Account Uin belonging to.
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// Sub-Account nickname.
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// Root account AK.
        /// Sub-Account AK.
        /// 2 temporary key.
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Security advice enumeration.
        /// Normal.
        /// Process now.
        /// 2 recommend reinforcement.
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
        /// Source IP quantity.
        /// </summary>
        [JsonProperty("IPCount")]
        public long? IPCount{ get; set; }

        /// <summary>
        /// Creation time.
        /// 
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last access Time
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// AK status. 
        /// 0: disabled.
        /// 1: enabled.
        /// 2: deleted (deleted in cam, the security center still retains the previous log).
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0 means detected.
        /// 1 indicates detecting.
        /// </summary>
        [JsonProperty("CheckStatus")]
        public long? CheckStatus{ get; set; }

        /// <summary>
        /// Cloud vendor type 0: tencent cloud 1: amazon web services 2: microsoft azure 3: google cloud 4: alibaba cloud 5: huawei cloud.
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
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubNickname", this.SubNickname);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Advice", this.Advice);
            this.SetParamArrayObj(map, prefix + "AccessKeyAlarmList.", this.AccessKeyAlarmList);
            this.SetParamArrayObj(map, prefix + "AccessKeyRiskList.", this.AccessKeyRiskList);
            this.SetParamSimple(map, prefix + "IPCount", this.IPCount);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
        }
    }
}

