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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Rule name. It supports [a-zA-Z0-9-\.]*.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Rule description
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("RuleDesc")]
        public string RuleDesc{ get; set; }

        /// <summary>
        /// Rule script
        /// </summary>
        [JsonProperty("RuleScript")]
        public string RuleScript{ get; set; }

        /// <summary>
        /// Tag
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public StringKV[] Tags{ get; set; }

        /// <summary>
        /// The associated match
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MatchCodeList")]
        public StringKV[] MatchCodeList{ get; set; }

        /// <summary>
        /// RuleCode
        /// </summary>
        [JsonProperty("RuleCode")]
        public string RuleCode{ get; set; }

        /// <summary>
        /// Region
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// User AppId
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// User OwnerUin
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CreateUin")]
        public string CreateUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RuleDesc", this.RuleDesc);
            this.SetParamSimple(map, prefix + "RuleScript", this.RuleScript);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "MatchCodeList.", this.MatchCodeList);
            this.SetParamSimple(map, prefix + "RuleCode", this.RuleCode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
        }
    }
}

