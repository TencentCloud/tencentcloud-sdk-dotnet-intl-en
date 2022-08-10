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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotPortraitRule : AbstractModel
    {
        
        /// <summary>
        /// ID of the rule being applied
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// ID of the rule that is set to verify requests by JavaScript challenge
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AlgManagedIds")]
        public long?[] AlgManagedIds{ get; set; }

        /// <summary>
        /// ID of the rule that is set to verify requests by CAPTCHA
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CapManagedIds")]
        public long?[] CapManagedIds{ get; set; }

        /// <summary>
        /// ID of the rule that is set to observe requests
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MonManagedIds")]
        public long?[] MonManagedIds{ get; set; }

        /// <summary>
        /// ID of the rule that is set to block requests
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DropManagedIds")]
        public long?[] DropManagedIds{ get; set; }

        /// <summary>
        /// Feature switch
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "AlgManagedIds.", this.AlgManagedIds);
            this.SetParamArraySimple(map, prefix + "CapManagedIds.", this.CapManagedIds);
            this.SetParamArraySimple(map, prefix + "MonManagedIds.", this.MonManagedIds);
            this.SetParamArraySimple(map, prefix + "DropManagedIds.", this.DropManagedIds);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}

